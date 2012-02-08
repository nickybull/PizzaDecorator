using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDecorator
{
    public abstract class Toppings : Pizza
    {
        public override abstract String getDescription();
    }
    
    public class Cheese : Toppings
    {
        Pizza za;
        public Cheese(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Cheese";
            }
            else
            {
                return za.getDescription() + ", and Cheese";
            }
        }

        public override double cost()
        {
            return .20 + za.cost();
        }
    }

    public class Pepperoni : Toppings
    {
        Pizza za;
        public Pepperoni(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Pepperoni";
            }
            else
            {
                return za.getDescription() + ", and Pepperoni";
            }
        }

        public override double cost()
        {
            return 1.00 + za.cost();
        }
    }

    public class Onions : Toppings
    {
        Pizza za;
        public Onions(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Onions";
            }
            else
            {
                return za.getDescription() + ", and Onions";
            }
        }

        public override double cost()
        {
            return .25 + za.cost();
        }
    }

    public class Peppers : Toppings
    {
        Pizza za;
        public Peppers(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Peppers";
            }
            else
            {
                return za.getDescription() + ", and Peppers";
            }
        }

        public override double cost()
        {
            return .75 + za.cost();
        }
    }

    public class Sausage : Toppings
    {
        Pizza za;
        public Sausage(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Sausage";
            }
            else
            {
                return za.getDescription() + ", and Sausage";
            }
        }

        public override double cost()
        {
            return 1.25 + za.cost();
        }
    }

    public class Bacon : Toppings
    {
        Pizza za;
        public Bacon(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Bacon";
            }
            else
            {
                return za.getDescription() + ", and Bacon";
            }
        }

        public override double cost()
        {
            return 2.00 + za.cost();
        }
    }

    public class Pineapple : Toppings
    {
        Pizza za;
        public Pineapple(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Pineapple";
            }
            else
            {
                return za.getDescription() + ", and Pineapple";
            }
        }

        public override double cost()
        {
            return .75 + za.cost();
        }
    }

    public class Ham : Toppings
    {
        Pizza za;
        public Ham(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Ham";
            }
            else
            {
                return za.getDescription() + ", and Ham";
            }
        }

        public override double cost()
        {
            return 1.00 + za.cost();
        }
    }

    public class Mushrooms : Toppings
    {
        Pizza za;
        public Mushrooms(Pizza za)
        {
            this.za = za;
        }

        public override String getDescription()
        {
            if (za.getBool())
            {
                za.setBool(false);
                return za.getDescription() + " with Mushrooms";
            }
            else
            {
                return za.getDescription() + ", and Mushrooms";
            }
        }

        public override double cost()
        {
            return .50 + za.cost();
        }
    }
}
