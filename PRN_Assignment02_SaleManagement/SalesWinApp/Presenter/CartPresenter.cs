using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class CartPresenter
    {
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        private decimal price;
        [DisplayName("Price")]
        public decimal Price {
            get 
            {
                return Math.Round(price, 2);
            }
            set 
            {
                price = value;
            } 
        }

        private decimal total;
        [DisplayName("Total")]
        public decimal Total
        {
            get
            {
                return Math.Round(total, 2);
            }
            set
            {
                total = value;
            }
        }

    }
}
