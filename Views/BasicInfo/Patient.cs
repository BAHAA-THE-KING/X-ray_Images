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

        public string? Required()
        {
            return "Patient name :" + baseInfo.name + "\n" +
                "Patient Sicknees :" + baseInfo.sickness[0] + "\n" +
                "Patient Status :" + baseInfo.status + "\n" +
                 "Patient doctor's :" + baseInfo.doctors[0] + "\n" +
                  "Patient diagonsis :" + statusInfo.diagnosis + "\n" +
                   "Patient indication :" + statusInfo.indication + "\n" +
                   "Patient phone :" + contactInfo.phone + "\n";

        }
    }
}
