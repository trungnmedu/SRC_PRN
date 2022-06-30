using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class AdminOrderPresenter
    {
        public int OrderID { get; set; }
        public string MemberName { get; set; }
        private DateTime orderDate;
        public DateTime OrderDate
        {
            get
            {
                return orderDate.Date;
            }
            set
            {
                orderDate = value;
            }
        }
        private decimal orderTotal;
        public decimal OrderTotal
        {
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
