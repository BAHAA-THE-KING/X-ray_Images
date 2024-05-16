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
        Status statusInfo;
        public Patient(Base baseInfo, Contact contactInfo, Other otherInfo, Status statusInfo)
        {
            this.baseInfo = baseInfo;
            this.contactInfo = contactInfo;
            this.otherInfo = otherInfo;
            this.statusInfo = statusInfo;
        }

        public override string? ToString()
        {
            return baseInfo.ToString() + "\n" + statusInfo.ToString()+"\n"
            + contactInfo.ToString() + "\n"
            + otherInfo.ToString();
        }
    }
}
