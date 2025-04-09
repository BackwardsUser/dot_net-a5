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
            public abstract class Toys
            {
                //public string ModeOfTransport { get; set; } //Air, Water, Land

                public double cost { get; set; }
                public string Description { get; set; }
                //hello
                //hi

                public string Name { get; set; }

                public string Manufacturing_Company { get; set; }
                public int Year_of_manufacture { get; set; }

                public int Minimum_age { get; set; }
                public int Maximum_age_limit { get; set; }
                public bool choke { get; set; }


                public int weight { get; set; }





                // A 'ConcreteProduct' class
                public class Cars : Toys
                {
                    public Cars()
                    {
                        cost = 0;
                        Description = "";
                        Name = "";
                        Manufacturing_Company = "";
                        Year_of_manufacture = 0;
                        Minimum_age = 0;
                        Maximum_age_limit = 10;
                        choke = false;
                        weight = 10;



                    }
                }


                // A 'ConcreteProduct' class
                public class dollhouses : Toys
                {
                    public dollhouses()
                    {
                        cost = 0;
                        Description = "";
                        Name = "";
                        Manufacturing_Company = "";
                        Year_of_manufacture = 0;
                        Minimum_age = 0;
                        Maximum_age_limit = 10;
                        choke = false;
                        weight = 10;
                    }
                    //hi
                }



                public class stuffed_animals : Toys
                {
                    public stuffed_animals()
                    {
                        cost = 0;
                        Description = "";
                        Name = "";
                        Manufacturing_Company = "";
                        Year_of_manufacture = 0;
                        Minimum_age = 0;
                        Maximum_age_limit = 10;
                        choke = false;
                        weight = 10;
                    }
                }


                public class rainbow_stackers : Toys
                {
                    public rainbow_stackers()
                    {
                        cost = 0;
                        Description = "";
                        Name = "";
                        Manufacturing_Company = "";
                        Year_of_manufacture = 0;
                        Minimum_age = 0;
                        Maximum_age_limit = 10;
                        choke = false;
                        weight = 10;
                    }
                }





                // The 'Creator' class
                public class Creator
                {
                    public Toys Gettoy(string type)
                    {
                        switch (type)
                        {
                            case "Cars":
                                return new Cars();
                            case "dollhouses":
                                return new dollhouses();

                            case "stuffed_animals":
                                return new stuffed_animals();
                            case " rainbow_stackers":
                                return new rainbow_stackers();



                            default:
                                throw new NotSupportedException();
                        }

                    }

                }
            }

        }
    }
}
