using System;
namespace RestaurantMenu
{
    public class MenuItem
    {
        private double price;
        private string description;
        private string category;

        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
 
        public MenuItem(double price, string description, string category)
        {
            this.price = price;
            this.description = description;
            this.category = category;       
        }

        public MenuItem() : this(0.0, "", "") { }
    }
}
