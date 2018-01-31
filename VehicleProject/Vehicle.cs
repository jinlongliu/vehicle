#region << Version Information >>
/*----------------------------------------------------------------
* ProjectName   ：VehicleProject
* Namespace     ：VehicleProject
* CLR-Version   ：4.0.30319.42000
* Author        ：Jinlong Liu
* CreateTime    ：2018/1/31 12:29:28
* UpdateTime    ：2018/1/31 12:29:28
* Version ：v1.0.0.0
*******************************************************************
* Copyright @ Jinlong Liu 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;

namespace VehicleProject
{
    public enum VehicleType
    {
        Car = 1,
        Plane = 2,
        Boat = 3,
    }

    ///abstract class for public property
    public abstract class Vehicle
    {
        private string _id;
        private int _enginePower = 0;
        private int _maxSpeed = 0;
        private VehicleType _type = 0;
        private bool _isMoving = false;

        //public string ID { get; set; }
        public string ID { get { return _id; } set { _id = value; } }

        public int EnginePower
        {
            get
            {
                return _enginePower;
            }
            set
            {
                _enginePower = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public bool IsMoving
        {
            get
            {
                return _isMoving;
            }
            set
            {
                _isMoving = value;
            }
        }

        public void Constructe(string id, int enginePower, int maxSpeed)
        {
            this.ID = id;
            this.EnginePower = enginePower;
            this.MaxSpeed = maxSpeed;
        }

        public abstract void Print();

        protected void printBase()
        {
            Console.WriteLine("\n");
            if(this._type == VehicleType.Car)
            {
                Console.WriteLine("Licence plate\t: {0}", this.ID);
            }
            else
            {
                Console.WriteLine("Registration\t: {0}", this.ID);
            }
            Console.WriteLine("Engine power\t: {0} KW", this.EnginePower);
            switch (this._type)
            {
                case VehicleType.Car:
                    Console.WriteLine("Maximal speed\t: {0} km/h", this.MaxSpeed);
                    Console.WriteLine("Type\t\t: personnal vehicle");
                    break;
                case VehicleType.Plane:
                    Console.WriteLine("Type\t\t: jet plane");
                    break;
                case VehicleType.Boat:
                    Console.WriteLine("Maximal speed\t: {0} knot/h", this.MaxSpeed);
                    break;
                default:
                    break;
            }
        }

    }
}
