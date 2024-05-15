using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ray_Images.Views.BasicInfo
{
    public  class Patient
    {
        Base baseInfo;
        Contact contactInfo;
        Other otherInfo;

        public Patient(Base baseInfo, Contact contactInfo, Other otherInfo)
        {
            this.baseInfo = baseInfo;
            this.contactInfo = contactInfo;
            this.otherInfo = otherInfo;
        }

        public override string? ToString()
        {
            return baseInfo.ToString() + "\n" + contactInfo.ToString() + "\n"
            + otherInfo.ToString();
        }
    }
}
