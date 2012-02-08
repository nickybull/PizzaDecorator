using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDecorator
{
    public class Hawaiian : Pizza
    {
        Pizza zia;
        public Hawaiian(Pizza zia)
        {
            this.zia = zia;
            this.zia = new Ham(this.zia);
            this.zia = new Pineapple(this.zia);
            this.zia = new Cheese(this.zia);
        }

        public override string getDescription()
        {
            return zia.getDescription();
        }

        public override double cost()
        {
            return zia.cost() - .50;
        }
    }
    public class MeatLovers : Pizza
    {
        Pizza zia;
        public MeatLovers(Pizza zia)
        {
            this.zia = zia;
            this.zia = new Ham(this.zia);
            this.zia = new Sausage(this.zia);
            this.zia = new Pepperoni(this.zia);
            this.zia = new Bacon(this.zia);
            this.zia = new Cheese(this.zia);
        }

        public override string getDescription()
        {
            return zia.getDescription();
        }

        public override double cost()
        {
            return zia.cost() - 1.50;
        }
    }
    public class Veggie : Pizza
    {
        Pizza zia;
        public Veggie(Pizza zia)
        {
            this.zia = zia;
            this.zia = new Onions(this.zia);
            this.zia = new Mushrooms(this.zia);
            this.zia = new Peppers(this.zia);
            this.zia = new Cheese(this.zia);
        }

        public override string getDescription()
        {
            return zia.getDescription();
        }

        public override double cost()
        {
            return zia.cost() - 1.00;
        }
    }
    public class Supreme : Pizza
    {
        Pizza zia;
        public Supreme(Pizza zia)
        {
            this.zia = zia;
            this.zia = new Peppers(this.zia);
            this.zia = new Sausage(this.zia);
            this.zia = new Bacon(this.zia);
            this.zia = new Onions(this.zia);
            this.zia = new Mushrooms(this.zia);
            this.zia = new Cheese(this.zia);
        }

        public override string getDescription()
        {
            return zia.getDescription();
        }

        public override double cost()
        {
            return zia.cost() - 2.00;
        }
    }
    public class Everything : Pizza
    {
        Pizza zia;
        public Everything(Pizza zia)
        {
            this.zia = zia;
            this.zia = new Ham(this.zia);
            this.zia = new Sausage(this.zia);
            this.zia = new Pepperoni(this.zia);
            this.zia = new Bacon(this.zia);
            this.zia = new Pineapple(this.zia);
            this.zia = new Onions(this.zia);
            this.zia = new Peppers(this.zia);
            this.zia = new Mushrooms(this.zia);
            this.zia = new Cheese(this.zia);
        }

        public override string getDescription()
        {
            return zia.getDescription();
        }

        public override double cost()
        {
            return zia.cost() - 3.50;
        }
    }
}
