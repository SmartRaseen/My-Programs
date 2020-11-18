
	C# - Event
	**********
	
	*	In general terms, an event is something special that is going to happen. 
		
	For example, 
	***********
	
	*	Microsoft launches events for developers, to make them aware about the features of new or existing products. 

	*	Microsoft notifies the developers about the event by email or other advertisement options. 
	
	*	So in this case, Microsoft is a publisher who launches (raises) an event and notifies the developers about it 
		and developers are the subscribers of the event and attend (handle) the event.

	For Example
	***********
	
	*	 For example, the button control in a Windows form has multiple events such as click, mouseover, etc.

	Example: Delegate
	*****************
	
	public delegate void someEvent();

	public someEvent someEvent;

	Now, to declare an event, use the event keyword before declaring a variable of delegate type, as below:

	Example: Event Declaration
	**************************
	
	public delegate void someEvent();

	public event someEvent someEvent;

	Thus, a delegate becomes an event using the event keyword.
	
---------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	Example Code : 
	**************
	
using System;
					
public class Program
{
	public static void Main()
	{
		EmployeeData data = new EmployeeData(26,"Raseen",25000);
		data.EmployeeID();
		data.EmployeeName();
		data.EmployeeSalary();
	}
}

public class EmployeeData
{
	byte id; string name; double salary;
	private Detail _detail;
	
	public EmployeeData(byte empID,string empName,double empSalary)
	{
		id = empID;
		name = empName;
		salary = empSalary;
		
		_detail = new Detail();
		_detail.dataDetail += EventHandler;
	}
	
	public void EventHandler()
	{
		Console.WriteLine("\n Event Handler : Is going to print the employee data..");
	}
	
	public void EmployeeID()
	{
		_detail.ID(id);
	}
	
	public void EmployeeName()
	{
		_detail.Name(name);
	}
	
	public void EmployeeSalary()
	{
		_detail.Salary(salary);
	}
}

public class Detail
{
	public delegate void DataHolder();
	public event DataHolder dataDetail;
	
	public void ID(byte id)
	{
		if(dataDetail!=null)
			dataDetail();
		
		Console.WriteLine("\n Employee ID : {0}",id);
	}
	
	public void Name(string name)
	{	
		if(dataDetail!=null)
			dataDetail();

		Console.WriteLine("\n Employee Name : {0}",name);
	}
	
	public void Salary(double salary)
	{	
		if(dataDetail!=null)
			dataDetail();

		Console.WriteLine("\n Employee Salary : {0}",salary);
	}
}

	Output :
	********
	
	Event Handler : Is going to print the employee data..

	Employee ID : 26

	Event Handler : Is going to print the employee data..

	Employee Name : Raseen

	Event Handler : Is going to print the employee data..

	Employee Salary : 25000
	

--------------------------------------------------------------------------------------------------------------------------------------------------------------

	Sample Code :
	*************
	
	using System;
					
public class Program
{
	public static void Main()
	{
		Number myNumber = new Number(100000);
		myNumber.PrintMoney();
		myNumber.PrintNumber();
		myNumber.PrintDecimal();
	}
}

class Number
{
    private PrintHelper _printHelper;

    public Number(int val)
    {
        _value = val;
           
        _printHelper = new PrintHelper();
        //subscribe to beforePrintEvent event
        _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
    }
    //beforePrintevent handler
    void printHelper_beforePrintEvent()
    {
        Console.WriteLine("\n BeforPrintEventHandler: PrintHelper is going to print a value");
    }

    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void PrintMoney()
    {
        _printHelper.PrintMoney(_value);
    }

    public void PrintNumber()
    {
        _printHelper.PrintNumber(_value);
    }
	public void PrintDecimal()
	{
		_printHelper.PrintDecimal(_value);
	}
}

public class PrintHelper
{
    // declare delegate 
    public delegate void BeforePrint();
    
    //declare event of type delegate
    public event BeforePrint beforePrintEvent;
      
    public PrintHelper()
    {

    }

    public void PrintNumber(int num)
    {
    //call delegate method before going to print
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Number: {0,-12:N0}", num);
    }

    public void PrintDecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();
    
        Console.WriteLine("Decimal: {0:G}", dec);
    }

    public void PrintMoney(int money)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Money: {0:C}", money);
    }

    public void PrintTemperature(int num)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Temperature: {0,4:N1} F", num);
    }
    public void PrintHexadecimal(int dec)
    {
        if (beforePrintEvent != null)
            beforePrintEvent();

        Console.WriteLine("Hexadecimal: {0:X}", dec);
    }
}

	Output :
	********
	
	BeforPrintEventHandler: PrintHelper is going to print a value
	Money: $100,000.00
	
	BeforPrintEventHandler: PrintHelper is going to print a value
	Number: 100,000     
	
	BeforPrintEventHandler: PrintHelper is going to print a value
	Decimal: 100000



