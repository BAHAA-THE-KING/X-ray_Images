using System;
using System.Windows.Forms;
using X_ray_Images.Classes;

namespace X_ray_Images
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            PDF.Generate(
                name: "John Doe",
                illness: "Hypertension",
                illnessDescription: "High blood pressure over a prolonged period.",
                status: "Stable",
                doctorName: "Dr. Smith",
                date: DateTime.Now,
                nextReview: DateTime.Now.AddMonths(3),
                diagnoses: "Stage 1 Hypertension",
                diagnosisDescription: "Blood pressure is consistently in the range of 140/90 to 159/99 mmHg.",
                cure: "Lifestyle changes and medication.",
                address: "123 Main St, Anytown, USA",
                phoneNumber: "(123) 456-7890"
            );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

    }
}
