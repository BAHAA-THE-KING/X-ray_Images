using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using X_ray_Images.Classes;

namespace X_ray_Images.Views.BasicInfo
{
    public class Patient
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
            return baseInfo.ToString() + "\n" + statusInfo.ToString() + "\n"
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
        public void ConvertToPDF(string path)
        {
            //string dateString = "22/5/2024";
            //string nextReviewString = "22/11/2024"; // Example next review date

            DateTime dateTime = DateTime.MinValue;
            DateTime nextdateReview = DateTime.MinValue;

            try
            {
                dateTime = DateTime.ParseExact(baseInfo.date, "d/M/yyyy", CultureInfo.InvariantCulture);
                nextdateReview = DateTime.ParseExact(otherInfo.nextdate, "d/M/yyyy", CultureInfo.InvariantCulture);
                //Console.WriteLine("Parsed DateTime: " + dateTime);
                //Console.WriteLine("Next DateTime: " + nextdateReview);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format.");
            }

            PDF.Generate(baseInfo.name, baseInfo.sickness, otherInfo.details, baseInfo.status, baseInfo.doctors,
                dateTime, nextdateReview, statusInfo.diagnosis, statusInfo.description, statusInfo.indication,
                contactInfo.address, contactInfo.phone, path);


        }
    }
}
