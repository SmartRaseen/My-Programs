using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class TestFuelTank
    {
        //Events

        public static void M1()
        {
            FuelTank f = new FuelTank();//publishers
            MsgCreator msg = new MsgCreator(); //Eventhandler
            f.TankFull += msg.OnFull;
            f.TankEmpty += msg.OnEmpty;
            f.TankReserv += msg.OnReserve;
            f.Changed += msg.OnChange;

            try
            {
                f.FillFuel(10); //OnChange
                f.UseFuel(5); //OnChange
                f.UseFuel(4); //OnChange, Reserve
                f.UseFuel(1); //OnChange, Empty
                f.FillFuel(20); //OnChange, Full
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
