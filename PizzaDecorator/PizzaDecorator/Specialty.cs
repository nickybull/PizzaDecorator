using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDecorator
{
    public class Hawaiian : Pizza
    {
        Pizza za;
        public Hawaiian(Pizza za)
        {
            this.za = za;
            this.za = new Ham(this.za);
            this.za = new Pineapple(this.za);
            this.za = new Cheese(this.za);
        }

        public override string getDescription()
        {
            return za.getDescription();
        }

        public override double cost()
        {
            return za.cost() - .50;
        }
    }
    public class MeatLovers : Pizza
    {
        Pizza za;
        public MeatLovers(Pizza za)
        {
            this.za = za;
            this.za = new Ham(this.za);
            this.za = new Sausage(this.za);
            this.za = new Pepperoni(this.za);
            this.za = new Bacon(this.za);
            this.za = new Cheese(this.za);
        }

        public override string getDescription()
        {
            return za.getDescription();
        }

        public override double cost()
        {
            return za.cost() - 1.50;
        }
    }
    public class Veggie : Pizza
    {
        Pizza za;
        public Veggie(Pizza za)
        {
            this.za = za;
            this.za = new Onions(this.za);
            this.za = new Mushrooms(this.za);
            this.za = new Peppers(this.za);
            this.za = new Cheese(this.za);
        }

        public override string getDescription()
        {
            return za.getDescription();
        }

        public override double cost()
        {
            return za.cost() - 1.00;
        }
    }
    public class Supreme : Pizza
    {
        Pizza za;
        public Supreme(Pizza za)
        {
            this.za = za;
            this.za = new Peppers(this.za);
            this.za = new Sausage(this.za);
            this.za = new Bacon(this.za);
            this.za = new Onions(this.za);
            this.za = new Mushrooms(this.za);
            this.za = new Cheese(this.za);
        }

        public override string getDescription()
        {
            return za.getDescription();
        }

        public override double cost()
        {
            return za.cost() - 2.00;
        }
    }
    public class Everything : Pizza
    {
        Pizza za;
        public Everything(Pizza za)
        {
            this.za = za;
            this.za = new Ham(this.za);
            this.za = new Sausage(this.za);
            this.za = new Pepperoni(this.za);
            this.za = new Bacon(this.za);
            this.za = new Pineapple(this.za);
            this.za = new Onions(this.za);
            this.za = new Peppers(this.za);
            this.za = new Mushrooms(this.za);
            this.za = new Cheese(this.za);
        }

        public override string getDescription()
        {
            return za.getDescription();
        }

        public override double cost()
        {
            return za.cost() - 3.50;
        }
    }
}
