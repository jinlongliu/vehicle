#region << Version Information >>
/*----------------------------------------------------------------
* ProjectName   ：VehicleProject
* Namespace     ：VehicleProject
* CLR-Version   ：4.0.30319.42000
* Author        ：Jinlong Liu
* CreateTime    ：2018/1/31 12:32:54
* UpdateTime    ：2018/1/31 12:32:54
* Version ：v1.0.0.0
*******************************************************************
* Copyright @ Jinlong Liu 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;

namespace VehicleProject
{
    public class Plane : Vehicle, IVehicle
    {
        private int _wingspan;
        private int _loadCapacity;
        private int _netWeight;

        //public int Wingspan { get => _wingspan; set => _wingspan = value; }
        //public int LoadCapacity { get => _loadCapacity; set => _loadCapacity = value; }
        //public int NetWeight { get => _netWeight; set => _netWeight = value; }

        public int Wingspan
        {
            get
            {
                return _wingspan;
            }
            set
            {
                _wingspan = value;
            }
        }

        public int LoadCapacity
        {
            get
            {
                return _loadCapacity;
            }
            set
            {
                _loadCapacity = value;
            }
        }

        public int NetWeight
        {
            get
            {
                return _netWeight;
            }
            set
            {
                _netWeight = value;
            }
        }

        public Plane(string id, int enginePower, int wingspan, int loadCapacity, int netWeight)
        {
            base.Constructe(id, enginePower, 0);
            this.Wingspan = wingspan;
            this.LoadCapacity = loadCapacity;
            this.NetWeight = netWeight;
            this.Type = VehicleType.Plane;
        }

        public void Move()
        {
            this.IsMoving = true;
            Console.WriteLine("This plane with registration {0} is flying now.", this.ID);
        }

        public override void Print()
        {
            base.printBase();
            Console.WriteLine("Wingspan\t: {0} m", this.Wingspan);
            Console.WriteLine("Load capacity\t: {0} t", this.LoadCapacity);
            Console.WriteLine("Net weight\t: {0} t", this.NetWeight);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
