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
            car1.Print(); // output to console

            ///output with json file
            Console.WriteLine();
            try
            {
                FileInfo fileInfo = new FileInfo("car.json");
                if (fileInfo.Exists)
                {
                    Console.WriteLine("Json file named car.json exist");
                }
                else
                {
                    fileInfo.Create();
                    Console.WriteLine("Create json file name car.json");
                }

                if (fileInfo.Exists)
                {
                    StreamWriter streamWriter = new StreamWriter(fileInfo.FullName);
                    streamWriter.WriteLine(car1.ToString());
                    streamWriter.Close();
                    Console.WriteLine("Write car1 info to file named car.json.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.WriteLine(car1.ToString());     //output to console with json format

            ///The program wait for stopping
            Console.ReadLine();
        }
    }
}
