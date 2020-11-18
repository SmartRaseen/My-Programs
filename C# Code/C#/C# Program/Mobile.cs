using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    enum Color { WHITE, BLACK, RED, BLUE, GREEN }

    public class Mobile
    {
        //Fields
        private long Number;
        private Color color;
        private float Cost;
        private string model = String.Empty;

        public long MobileNum
        {
            get
            {
                return Number;
            }
            set
            {
                if (value < 9000000000 || value > 10000000000)
                    Console.WriteLine("Invalid Mobile Number");
                if (value < 9000000000L || value > 10000000000L)
                {
                    Console.WriteLine("Invalid Mobile Number");
                    return;
                }
                Number = value;
            }
        }
        public string MobileColor
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }
        public float MobileCost
        {
            get
            {
                return Cost;
            }
            set
            {
                //Cost should be zero Must be multiple of 50/-,Not More Than 100,000
                if (value < 0)
                {
                    Console.WriteLine("Value Should Not Be Lesser Than Zero !!!");
                    return;
                }
                else if ((value % 50) != 0)
                {
                    Console.WriteLine("ERROR!!! Value Must Be Multiples Of 50 !!!");
                    return;
                }
                else if (value > 100000)
                {
                    Console.WriteLine("Value Should Not Be Greater Than 1,00,000 !!!");
                    return;
                }
                Cost = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public void MakeaCall(long CalledNo)
        {
            Console.WriteLine("\n Calling.... " + CalledNo);
        }
        public void ReceivedCall(long CallingNo)
        {
            Console.WriteLine("\n Received Call From.... " + CallingNo);
        }
        public void SendMsg(long MsgToSend, String Msg)
        {
            Console.WriteLine("\n "+ Msg + " Sending Msg To... " + MsgToSend);
        }
        public void ReceivedMsg(long MsgFrom, String Msg)
        {
            Console.WriteLine("\n "+ Msg + " Sending Msg To... " + MsgFrom);
        }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("\n Mobile Number : " + MobileNum);
            Console.WriteLine("\n Mobile Color : " + MobileColor);
            Console.WriteLine("\n Mobile Cost :" + MobileCost);
            Console.WriteLine("\n Mobile Model :" + Model);
        }
    }
    public class test
    {
        public static void Main()
        { 
            Console.WriteLine("\n Mobile Detils");
            Console.WriteLine(" ***** ******");
            Mobile m = new Mobile();
            m.MobileNum = 9985793825;
            Console.WriteLine("\n Mobile Number 1 : "+m.MobileNum);
            m.MobileNum = 9759498847;
            Console.WriteLine("\n Mobile Number 2 : "+m.MobileNum);
            m.MobileCost = 14000;
            m.Model = "Oppo A57";
            m.MakeaCall(9985793825);
            m.ReceivedCall(9759498847);
            m.SendMsg(9759498847,"Hello Brother");
            m.ReceivedMsg(9985793825,"Hi Brother");
            m.ShowDetails();
            Console.ReadLine();
        }
    }
}


