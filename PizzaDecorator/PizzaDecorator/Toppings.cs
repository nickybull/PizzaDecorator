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
        Pizza zia;
        public Cheese(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Cheese";
            }
            else
            {
                return zia.getDescription() + ", and Cheese";
            }
        }

        public override double cost()
        {
            return .20 + zia.cost();
        }
    }

    public class Pepperoni : Toppings
    {
        Pizza zia;
        public Pepperoni(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Pepperoni";
            }
            else
            {
                return zia.getDescription() + ", and Pepperoni";
            }
        }

        public override double cost()
        {
            return 1.00 + zia.cost();
        }
    }

    public class Onions : Toppings
    {
        Pizza zia;
        public Onions(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Onions";
            }
            else
            {
                return zia.getDescription() + ", and Onions";
            }
        }

        public override double cost()
        {
            return .25 + zia.cost();
        }
    }

    public class Peppers : Toppings
    {
        Pizza zia;
        public Peppers(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Peppers";
            }
            else
            {
                return zia.getDescription() + ", and Peppers";
            }
        }

        public override double cost()
        {
            return .75 + zia.cost();
        }
    }

    public class Sausage : Toppings
    {
        Pizza zia;
        public Sausage(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Sausage";
            }
            else
            {
                return zia.getDescription() + ", and Sausage";
            }
        }

        public override double cost()
        {
            return 1.25 + zia.cost();
        }
    }

    public class Bacon : Toppings
    {
        Pizza zia;
        public Bacon(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Bacon";
            }
            else
            {
                return zia.getDescription() + ", and Bacon";
            }
        }

        public override double cost()
        {
            return 2.00 + zia.cost();
        }
    }

    public class Pineapple : Toppings
    {
        Pizza zia;
        public Pineapple(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Pineapple";
            }
            else
            {
                return zia.getDescription() + ", and Pineapple";
            }
        }

        public override double cost()
        {
            return .75 + zia.cost();
        }
    }

    public class Ham : Toppings
    {
        Pizza zia;
        public Ham(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Ham";
            }
            else
            {
                return zia.getDescription() + ", and Ham";
            }
        }

        public override double cost()
        {
            return 1.00 + zia.cost();
        }
    }

    public class Mushrooms : Toppings
    {
        Pizza zia;
        public Mushrooms(Pizza zia)
        {
            this.zia = zia;
        }

        public override String getDescription()
        {
            if (zia.getBool())
            {
                zia.setBool(false);
                return zia.getDescription() + " with Mushrooms";
            }
            else
            {
                return zia.getDescription() + ", and Mushrooms";
            }
        }

        public override double cost()
        {
            return .50 + zia.cost();
        }
    }
}
