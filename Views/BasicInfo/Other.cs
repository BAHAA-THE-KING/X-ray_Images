using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Views.BasicInfo
{
    public class Other
    {
        public string details;
        public string nextdate;
        public Other()
        {
            this.details = details;
            this.nextdate = nextdate;
        }
        public Other(string details, string nextdate)
        {
            this.details = details;
            this.nextdate = nextdate;
        }
        public override string? ToString()
        {
            return "details: " + details + "\n" + "nextdate: " + nextdate;


        }
    }
}
