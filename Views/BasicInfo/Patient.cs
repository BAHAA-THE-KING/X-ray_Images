using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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
            string patientInfo = "Patient name: " + baseInfo.name + "\n";
            if (baseInfo.sickness.Count > 0)
            {
                patientInfo += "Patient Sickness: " + baseInfo.sickness[0] + "\n";
            }
            else
            {
                patientInfo += "Patient Sickness: N/A\n";
            }
            patientInfo += "Patient Status: " + baseInfo.status + "\n";

            if (baseInfo.doctors.Count > 0)
            {
                patientInfo += "Patient Doctor: " + baseInfo.doctors[0] + "\n";
            }
            else
            {
                patientInfo += "Patient Doctor: N/A\n";
            }
            patientInfo += "Patient Diagnosis: " + statusInfo.diagnosis + "\n" +
               "Patient Indication: " + statusInfo.indication + "\n" +
               "Patient Phone: " + contactInfo.phone + "\n";
            return patientInfo;


        }
    }
}
