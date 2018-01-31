#region << Version Information >>
/*----------------------------------------------------------------
* ProjectName   ：VehicleProject
* Namespace     ：VehicleProject
* CLR-Version   ：4.0.30319.42000
* Author        ：Jinlong Liu
* CreateTime    ：2018/1/31 12:33:34
* UpdateTime    ：2018/1/31 12:33:34
* Version ：v1.0.0.0
*******************************************************************
* Copyright @ Jinlong Liu 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;

namespace VehicleProject
{
    public class Boat : Vehicle
    {
        private int _crossTonnage;

        //public int CrossTonnage { get => crossTonnage; set => crossTonnage = value; }
        public int CrossTonnage
        {
            get
            {
                return _crossTonnage;
            }
            set
            {
                _crossTonnage = value;
            }
        }

        public Boat(string id, int enginePower, int maxSpeed, int crossTonnage)
        {
            base.Constructe(id, enginePower, maxSpeed);
            this.CrossTonnage = crossTonnage;
            this.Type = VehicleType.Boat;
        }

        public override void Print()
        {
            base.printBase();
            Console.WriteLine("Cross Tonnage\t: {0} kg", this.CrossTonnage);
        }
    }
}
