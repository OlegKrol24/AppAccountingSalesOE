using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppAccountingSalesOE
{
    public class Goods
    {
        private int iD;
        private string name;
        private string category;
        private string manufacturing_country;
        private decimal price;
        private int warranty_months;
        private int stock_quantity;
        private string description;
        private string image;

        public int ID { get => iD; }
        public string Name { get => name; set; }
        public string Category { get => category; set; }
        public string ManufacturingCountry { get => manufacturing_country; set; }
        public decimal Price { get => price; set; }
        public int WarrantyMonths { get => warranty_months; set; }
        public int StockQuantity { get => stock_quantity; set; }
        public string Description { get => description; set; }
        public string Image { get => image; }

        public Goods()
        {
            iD = -1;
            name = "";
            category = "";
            manufacturing_country = "";
            price = 0;
            warranty_months = 0;
            stock_quantity = 0;
            description = "";
            image = "";
        }

        public Goods(int iD, string name, string category, string manufacturing_country, decimal price, int warranty_months, int stock_quantity, string description, string image)
        {
            this.iD = iD;
            this.name = name;
            this.category = category;
            this.manufacturing_country = manufacturing_country;
            this.price = price;
            this.warranty_months = warranty_months;
            this.stock_quantity = stock_quantity;
            this.description = description;
            this.image = image;
        }

        public Goods(string info)
        {
            if (info != null)
            {
                string[] values = info.Split('|');

                if (info.Length >= 4)
                {
                    try { iD = Convert.ToInt32(values[0]); } catch (Exception ex) { iD = -1; }
                    try { name = values[1]; } catch (Exception ex) { name = ""; }
                    try { category = values[2]; } catch (Exception ex) { category = ""; }
                    try { manufacturing_country = values[3]; } catch (Exception ex) { manufacturing_country = ""; }
                    try { price = Convert.ToDecimal(values[4]); } catch (Exception ex) { price = 0; }

                    if (info.Length >= 6)
                    {
                        try { warranty_months = Convert.ToInt32(values[5]); } catch (Exception ex) { warranty_months = 0; }
                        try { stock_quantity = Convert.ToInt32(values[6]); } catch (Exception ex) { stock_quantity = 0; }
                        try { description = values[7]; } catch (Exception ex) { description = ""; }
                        try { image = values[8]; } catch (Exception ex) { image = ""; }
                    }
                }
            }
        }
    }
}
