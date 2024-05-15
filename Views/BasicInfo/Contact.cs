using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace X_ray_Images.Views.BasicInfo
{
    public class Contact
    {
        public string Address;
        public int phone;

        public Contact(string address, int phone)
        {
            Address = address;
            this.phone = phone;
        }
        public Contact()
        {
            Address = "";
            this.phone = -1;
        }
        public override string? ToString()
        {
            return "address: " + Address + "\n" + "phone: " + phone ;
        }
    }
}
