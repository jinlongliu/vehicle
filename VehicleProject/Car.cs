#region << Version Information >>
/*----------------------------------------------------------------
* ProjectName   ：VehicleProject
* Namespace     ：VehicleProject
* CLR-Version   ：4.0.30319.42000
* Author        ：Jinlong Liu
* CreateTime    ：2018/1/31 12:32:16
* UpdateTime    ：2018/1/31 12:32:16
* Version ：v1.0.0.0
*******************************************************************
* Copyright @ Jinlong Liu 2018. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;

namespace VehicleProject
{
    public class Car : Vehicle, IVehicle, IEquatable<Car>
    {
        private string _colour;

        //public string Colour { get => _colour; set => _colour = value; }

        public Car(string id, int enginePower, int maxSpeed, string colour)
        {
            base.Constructe(id, enginePower, maxSpeed);
            this.Colour = colour;
            this.Type = VehicleType.Car;
        }

        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return this == null;
            if (!(obj is Car)) return false;
            Car car = obj as Car;

            if (this.ID != car.ID)
            {
                return false;
            }
            else if (this.EnginePower != car.EnginePower)
            {
                return false;
            }
            else if (this.MaxSpeed != car.MaxSpeed)
            {
                return false;
            }
            else if (this.Colour != car.Colour)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Equals(Car other)
        {
            return this.Equals((object)other);
        }

        public override int GetHashCode()
        {
            if (this.Colour != null)
            {
                return this.Colour.GetHashCode();
            }
            return 0;
        }

        public void Move()
        {
            this.IsMoving = true;
            Console.WriteLine("The car with licence plate {0} is driving now.", this.ID);
        }

        public override void Print()
        {
            base.printBase();
            Console.WriteLine("Colour\t\t: {0}", this.Colour);
        }

        ///Prepare for json output
        public override string ToString()
        {
            string json = "{";
            json += "\"id\":\"";
            json += this.ID;
            json += "\",";
            json += "\"enginePower\":";
            json += this.EnginePower;
            json += ",";
            json += "\"maxSpeed\":";
            json += this.MaxSpeed;
            json += ",";
            json += "\"isMoving\":";
            json += this.IsMoving.ToString().ToLower();
            json += ",";
            json += "\"colour\":\"";
            json += this.Colour;
            json += "\"";
            json += "}";
            return json;
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return car1.Equals(car2);
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }
    }
}
