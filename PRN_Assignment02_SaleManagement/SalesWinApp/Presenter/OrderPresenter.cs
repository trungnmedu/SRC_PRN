using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class OrderPresenter
    {
        [DisplayName("Order ID")]
        public int OrderID { get; set; }

        [DisplayName("Member Name")]
        public string MemberName { get; set; }

        private DateTime orderDate;
        [DisplayName("Order Date")]
        public DateTime OrderDate {
            get {
                return orderDate.Date;
            }
            set {
                orderDate = value;
            }
        }

        private decimal orderTotal;
        [DisplayName("Order Total")]
        public decimal OrderTotal {
            get
            {
                return Math.Round(orderTotal, 2);
            }
            set
            {
                orderTotal = value;
            }
        }
    }
}
