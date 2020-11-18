

 Create UDT and Retrieve .ToString(),ToXml(), and Return As Table
 ****************************************************************
 
using System;
using System.Data.SqlTypes;
using System.IO;
using Microsoft.SqlServer.Server;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

[Serializable]
[SqlUserDefinedType(Format.UserDefined, IsByteOrdered = true, MaxByteSize = 6000)]


public class ListProduct : INullable, IBinarySerialize
{
    private bool is_Null;
    private const int list_Length = 20;
    private int list_Size;
    private SqlInt32 productID;
    private SqlString productName;
    private SqlInt32 productQuantity;
    private SqlDecimal productPrice;


    public bool IsNull
    {
        get
        {
            return is_Null;
        }
    }

    public static ListProduct Null
    {
        get
        {
            ListProduct list = new ListProduct();
            list.is_Null = true;
            return list;
        }
    }

    public int ListSize
    {
        get
        {
            return list_Size;
        }
        set
        {
            if (value > list_Length)
                list_Size = list_Length;
            else
                list_Size = value;
        }
    }
    
    public List<Product> ProductList { get; set; }
    public int Count { get; set; }
    public static ListProduct Parse(SqlString sqlString)
    {
        if (sqlString.IsNull)
            return Null;
        ListProduct list = new ListProduct();
        list.ProductList = list.GetProductList(sqlString.Value);    
        return list;
    }

    public List<Product> GetProductList(string listData)
    {
        string[] delimiter = new string[5] { "#", "#", "#", "#", "#" };
        List<Product> list = new List<Product>();
        string[] listofProduct = listData.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        Count = listofProduct.Length > list_Length ? list_Length : listofProduct.Length;
        for(int i = 0; i < Count;i++)
        {
            list.Add(Product.Parse(listofProduct[i]));
        }
        return list;
    }

    public override string ToString()
    {
        if (this.is_Null)
            return null;

        return string.Join(",",ProductList);
    }

    public static bool ValidateProduct(SqlInt32 productID, SqlString productName, SqlInt32 productQuantity, SqlDecimal productPrice)
    {
        if (productID.IsNull)
            return false;

        if (productName.IsNull)
            return false;
        
        if (productQuantity.IsNull)
            return false;

        if (productPrice.IsNull)
            return false;

        return true;
    }

    //[SqlFunction(
    //DataAccess = DataAccessKind.Read,
    //FillRowMethodName = "Products_FillRow",
    //TableDefinition = "   ProductID INT, ProductName NVARCHAR(100),ProductQuantity INT,ProductPrice DECIMAL")]
    //public static IEnumerable Products(int ID)
    //{
    //    ArrayList resultCollection = new ArrayList();

    //    using (SqlConnection connection = new SqlConnection("context connection=true"))
    //    {
    //        connection.Open();
    //            using (SqlCommand sqlCommand = new SqlCommand(
    //                "SELECT " +
    //                "[ProductID], [ProductName], [ProductPrice], [ProductQuantity] " +
    //                "FROM [Product] " +
    //                "WHERE [ID] >= @ID",
    //                connection))
    //            {
    //                SqlParameter Param = sqlCommand.Parameters.Add(
    //                    "@ID",
    //                    SqlDbType.Int);
    //                Param.Value = ID;

    //                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
    //                {
    //                    while (dataReader.Read())
    //                    {
    //                        SqlInt32 productID = dataReader.GetSqlInt32(1);
    //                        SqlString productName = dataReader.GetSqlString(1);
    //                        SqlInt32 productQuantity = dataReader.GetSqlInt32(1);
    //                        SqlDecimal productPrice = dataReader.GetSqlDecimal(1);
    //                        if (ValidateProduct(productID,productName, productQuantity, productPrice))
    //                        {
    //                            resultCollection.Add(new ListProduct(
    //                                dataReader.GetSqlInt32(0), productID, dataReader.GetSqlInt32(0), productName, 
    //                                dataReader.GetSqlInt32(0), productQuantity, dataReader.GetSqlInt32(0), productPrice));
    //                        }
    //                    }
    //                }
    //            }
    //    }
    //    return resultCollection;
    //}

    [SqlFunction(DataAccess = DataAccessKind.Read, Name = "AS_TABLE", FillRowMethodName = "FillRow",
        TableDefinition = "ProductID INT, ProductName NVARCHAR(100),ProductQuantity INT,ProductPrice DECIMAL")]
    public static IEnumerable GetAsTable(ListProduct obj)
    {
        var tableList = new ArrayList();
        var arrayObj = obj.ProductList;
        
        foreach (var item in arrayObj)
        {
            tableList.Add(new Product() { ProductID = item.ProductID, ProductName = item.ProductName, ProductQuantity = item.ProductQuantity, ProductPrice = item.ProductPrice });
        }
        return tableList;
    }
    
    public static void FillRow(object result, out SqlInt64 ProductID, out SqlString ProductName, out SqlInt64 ProductQuantity, out SqlDecimal ProductPrice)
    {
        if (result is Product rowObj)
        {
            ProductID = new SqlInt64(rowObj.ProductID);
            ProductName = new SqlString(rowObj.ProductName);
            ProductQuantity = new SqlInt64(rowObj.ProductQuantity);
            ProductPrice = new SqlDecimal(rowObj.ProductPrice);
        }
        else
        {
            ProductID = default(SqlInt64);
            ProductName = default(SqlString);
            ProductQuantity = default(SqlInt64);
            ProductPrice = default(SqlDecimal);
        }
    }

    public static void ProductTable(ListProduct listObject)
    {
        using (SqlConnection connection = new SqlConnection("context connection=true"))
        {
            connection.Open();
            foreach (Product product in listObject.ProductList)
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Insert into Product(productID,productName,productQuantity,productPrice) values(@ID,@name, @quantity, @price)";
                command.Parameters.AddWithValue("@ID", product.ProductID);
                command.Parameters.AddWithValue("@name", product.ProductName);
                command.Parameters.AddWithValue("@quantity", product.ProductQuantity);
                command.Parameters.AddWithValue("@price", product.ProductPrice);

                command.ExecuteNonQuery();
            }
        }
    }

    public static void Products_FillRow(ListProduct listObject)
    {
        using (SqlConnection connection = new SqlConnection("context connection=true"))
        {
            connection.Open();
            foreach (Product product in listObject.ProductList)
            {
                int productID = product.ProductID;
                string productName = product.ProductName;
                int productQuantity = product.ProductQuantity;
                decimal productPrice = product.ProductPrice;
            }
        }
    }

    public string ToXml()
    {
        var serializer = new XmlSerializer(typeof(ListProduct));
        var stringWriter = new StringWriter();
        serializer.Serialize(stringWriter,this);
        return stringWriter.ToString();
    }
    
    public void Write(BinaryWriter binaryWriter)
    {
        var formatter = new BinaryFormatter();
        var stream = new MemoryStream();
        formatter.Serialize(stream,ProductList);
        var byteArray = stream.ToArray();
        var byteLength = byteArray.Length;
        binaryWriter.Write(byteLength);
        binaryWriter.Write(byteArray);
        binaryWriter.Write(Count);
        binaryWriter.Write(is_Null);
    }

    public void Read(BinaryReader binaryReader)
    {
            var byteLength = binaryReader.ReadInt32();
            var byteArray = binaryReader.ReadBytes(byteLength);
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream(byteArray);
            ProductList = (List<Product>)formatter.Deserialize(stream);
            Count = binaryReader.ReadInt32();
            is_Null = binaryReader.ReadBoolean();
    }

    public ListProduct AddProducts(SqlString sqlString)
    {
        var product = Product.Parse(sqlString);

        if(Count<list_Length)
        {
            ProductList.Add(product);
            Count++;
        }
        return this;
    }

    public ListProduct RemoveProduct()
    {
        if (Count > 0)
        {
            ProductList.RemoveAt(Count - 1);
            Count--;
        }
        return this;
    }
}

[Serializable]
[SqlUserDefinedType(Format.UserDefined, IsByteOrdered = true, MaxByteSize = 6000)]
public class Product : INullable, IBinarySerialize
{
    private bool is_Null;
    private int productID;
    private string productName;
    private int productQuantity;
    private decimal productPrice;

    public bool IsNull
    {
        get
        {
            return is_Null;
        }
    }

    public static Product Null
    {
        get
        {
            Product list = new Product();
            list.is_Null = true;
            return list;
        }
    }

    public int ProductID
    {
        get
        {
            return productID;
        }
        set
        {
            int temp = productID;
            productID = value;
            if (!ValidateProduct())
            {
                productID = temp;
                throw new ArgumentException("Invalid ProductID..");
            }
        }
    }

    public string ProductName
    {
        get
        {
            return productName;
        }
        set
        {
            string temp = productName;
            productName = value;
            if (!ValidateProduct())
            {
                productName = temp;
                throw new ArgumentException("Invalid ProductName..");
            }
        }
    }

    public int ProductQuantity
    {
        get
        {
            return productQuantity;
        }
        set
        {
            int temp = productQuantity;
            productQuantity = value;
            if (!ValidateProduct())
            {
                productQuantity = temp;
                throw new ArgumentException("Invalid ProductQuantity..");
            }
        }
    }

    public decimal ProductPrice
    {
        get
        {
            return productPrice;
        }
        set
        {
            decimal temp = productPrice;
            productPrice = value;
            if (!ValidateProduct())
            {
                productPrice = temp;
                throw new ArgumentException("Invalid ProductPrice..");
            }
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(productID);
        builder.Append(",");
        builder.Append(productName);
        builder.Append(",");
        builder.Append(productQuantity);
        builder.Append(",");
        builder.Append(productPrice);
        return builder.ToString();
    }

    [SqlMethod(OnNullCall = false)]
    public static Product Parse(SqlString s)
    {
        if (s.IsNull)
            return Null;

        else
        {
            Product list = new Product();
            string[] productData = s.Value.Split(",".ToCharArray());
            list.productID = int.Parse(productData[0]);
            list.productName = productData[1].ToString();
            list.productQuantity = int.Parse(productData[2]);
            list.productPrice = decimal.Parse(productData[3]);

            if (!list.ValidateAllProduct())
                throw new ArgumentException("Invalid Product Values..");
            return list;
        }

    }

    public bool ValidateProduct()
    {
        if ((productID > 0) || (productQuantity > 0) || (productPrice > 0) || !String.IsNullOrEmpty(productName))
            return true;
        else
            return false;
    }

    public bool ValidateAllProduct()
    {
        if ((productID > 0) && (productQuantity > 0) && (productPrice > 0) && !String.IsNullOrEmpty(productName))
            return true;
        else
            return false;
    }

    public void Write(BinaryWriter w)
    {
        w.Write(productID);
        w.Write(productName);
        w.Write(productQuantity);
        w.Write(productPrice);
    }

    public void Read(BinaryReader r)
    {
        productID = r.ReadInt32();
        productName = r.ReadString();
        productQuantity = r.ReadInt32();
        productPrice = r.ReadDecimal();
    }
}