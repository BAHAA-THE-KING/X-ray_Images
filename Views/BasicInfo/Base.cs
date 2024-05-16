using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Views.BasicInfo
{
    public class Base   
    {
        public string name;
        public List<string> sickness;
        public string status;
        public List<string> doctors;
        public string date;

        public Base()
        {
            this.name = "";
            this.sickness = new List<string>();
            this.status = "";
            this.doctors = new List<string>();
            this.date = "";
        }
            public Base(string name, List<string> sickness, string status, List<string> doctors, string date)
        {
            this.name = name;
            this.sickness = sickness;
            this.status = status;
            this.doctors = doctors;
            this.date = date;
        }

        public override string? ToString()
        {
            return "name: " + name + "\n" + "sickness: " + sickness[0]+"\n"
                +"status: "+status+"\n" + "doctors: " + doctors[0] + "\n"
                +"date :" + date;
                ;
        }
    }
}
