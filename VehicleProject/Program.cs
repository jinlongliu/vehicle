#region << Version Information >>
/*----------------------------------------------------------------
* ProjectName   ：VehicleProject
* Namespace     ：VehicleProject
* CLR-Version   ：4.0.30319.42000
* Author        ：Jinlong Liu
* CreateTime    ：2018/1/31 12:22:13
* UpdateTime    ：2018/1/31 12:22:13
* Version ：v1.0.0.0
*******************************************************************
* Copyright @ Jinlong Liu 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;

namespace VehicleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print car1 information
            Car car1 = new Car("NF123456", 147, 200, "green");
            car1.Print();

            ///Print car2 information
            Car car2 = new Car("NF654321", 150, 195, "blue");
            car2.Print();
            Console.WriteLine();

            ///Compare car1 and car2 
            if (car1.Equals(car2))
            {
                Console.WriteLine("Car1 is the same as Car2.");
            }
            else
            {
                Console.WriteLine("Car1 is different from Car2.");
            }

            ///Print plane information
            Plane plane = new Plane("LN1234", 1000, 30, 2, 2);
            plane.Print();
            Console.WriteLine();

            plane.Move();   //ask plane to fly
            car1.Move();    //ask car1 to driver
            
            ///Print boat information
            Boat boat = new Boat("ABC123", 100, 30, 500);
            boat.Print();

            ///The program wait for stopping
            Console.ReadLine();
        }
    }
}
