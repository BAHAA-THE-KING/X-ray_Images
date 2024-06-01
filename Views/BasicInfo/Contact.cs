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
        public string address;
        public string phone;

        public Contact(string address, string phone)
        {
            this.address = address;
            this.phone = phone;
        }
        public Contact()
        {
            this.address = "";
            this.phone = "";
        }
        public override string? ToString()
        {
            return "address: " + this.address + "\n" + "phone: " + this.phone;
        }
    }
}
