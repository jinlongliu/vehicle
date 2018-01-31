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
using System.IO;

namespace VehicleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print car1 information
            Car car1 = new Car("NF123456", 147, 200, "green");
            car1.Print();

            ///The program wait for stopping
            Console.ReadLine();
        }
    }
}
