namespace Factory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Week10_2_Factory
    {
        class Classes
        {
            // The 'Product' abstract class
            public abstract class IVehicle
            {
                public string ModeOfTransport { get; set; } //Air, Water, Land

                public double cost {  get; set; }
                public string Description { get; set; }

                public string Name {  get; set; }

                public string Manufacturing_Company { get; set; }

                


5. Year of manufacture
6. Minimum age limit
7. Maximum age limit
8. Whether they contain parts which could be considered a choking hazard
9. Weight
            


            // A 'ConcreteProduct' class
            public class Car : IVehicle
            {
                public Car()
                {
                    ModeOfTransport = "Land";
                }
            }


            // A 'ConcreteProduct' class
            public class Boat : IVehicle
            {
                public Boat()
                {
                    ModeOfTransport = "Water";
                }
            }


            // The 'Creator' class
            public class Creator
            {
                public IVehicle GetVehicle(string type)
                {
                    switch (type)
                    {
                        case "Car":
                            return new Car();
                        case "Boat":
                            return new Boat();
                        default:
                            throw new NotSupportedException();
                    }

                }

            }
        }

    }
}
