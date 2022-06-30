using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWinApp.Presenter
{
    public class MemberPresenter
    {
        [DisplayName("Member ID")]
        public int MemberId { get; set; }

        [DisplayName("Full Name")]
        public string Fullname { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [DisplayName("City")]
        public string City { get; set; }

        [DisplayName("Country")]
        public string Country { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
