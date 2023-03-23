using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClone
{
    public class Engine : ICloneable
    {
        public string Type { get; set; }
        public int Power { get; set; }

        public object Clone()
        {
            return new Engine
            {
                Type = this.Type,
                Power = this.Power
            };
        }
    }

    public abstract class Transport : ICloneable
    {
        public int Weight { get; set; }
        public Engine Engine { get; set; }

        public abstract object Clone();
    }

    public class Car : Transport
    {
        public int Seats { get; set; }

        public override object Clone()
        {
            return new Car
            {
                Weight = this.Weight,
                Engine = this.Engine.Clone() as Engine,//вернет null вместо исключкния
                Seats = this.Seats
            };
        }
    }

    public class Plane : Transport
    {
        public int Passengers { get; set; }

        public override object Clone()
        {
            return new Plane
            {
                Weight = this.Weight,
                Engine = this.Engine.Clone() as Engine,
                Passengers = this.Passengers
            };
        }
    }

    public class Ship : Transport
    {
        public int Crew { get; set; }

        public override object Clone()
        {
            return new Ship
            {
                Weight = this.Weight,
                Engine = this.Engine.Clone() as Engine,
                Crew = this.Crew
            };
        }
    }
}

