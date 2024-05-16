using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Views.BasicInfo
{
    public class Status
    {
        public string diagnosis;
        public string description;
        public string indication;
        public Status()
        {
            this.diagnosis = "";
            this.description = "";
            this.indication = "";
        }
        public Status(string diagnosis, string description, string indication)
        {
            this.diagnosis = diagnosis;
            this.description = description;
            this.indication = indication;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return "diagnosis :" + this.diagnosis + "\n"
           + "description :" + this.description + "\n"
           + "indication :"+ this.indication;
        }
    }
}
