using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaDecorator
{
    public abstract class Pizza
    {
        public String description = "Pizza";
        bool firstTopping = true;
        public virtual String getDescription()
        {
            return description;
        }
        public abstract double cost();

        public bool getBool()
        {
            return firstTopping;
        }

        public void setBool(bool first)
        {
            firstTopping = first;
        }
    }

    public class ThinCrust : Pizza
    {
        public ThinCrust()
        {
            description = "Thin Crust Pizza"; 
        }

        public override double cost()
        {
            return 3.00;
        }
    }

    public class ThickCrust : Pizza
    {
        public ThickCrust()
        {
            description = "Thick Crust Pizza";
        }

        public override double cost()
        {
            return 5.00;
        }
    }

    public class Chicago : Pizza
    {
        public Chicago()
        {
            description = "Chicago Style Pizza";
        }

        public override double cost()
        {
            return 6.00;
        }
    }

    public class NewYork : Pizza
    {
        public NewYork()
        {
            description = "New York Style Pizza";
        }

        public override double cost()
        {
            return 4.00;
        }
    }
}