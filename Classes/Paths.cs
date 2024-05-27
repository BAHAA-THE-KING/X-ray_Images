using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace X_ray_Images.Classes
{
    public class Paths
    {
        public const string AudioTempDir = "C:\\Temp";
        public const string AudioTempFile = AudioTempDir + "\\audio.wav";
        public static readonly string AppPath = Application.StartupPath;
        public static readonly string NetPath = Directory.GetParent(AppPath).FullName;
        public static readonly string DebugPath = Directory.GetParent(NetPath).FullName;
        public static readonly string BinPath = Directory.GetParent(DebugPath).FullName;
        public static readonly string ProjectPath = Directory.GetParent(BinPath).FullName;
        public static readonly string ReportsPath = Path.Combine(ProjectPath, "reports");
        public static string CreatePath(string PatientName)
        {
            return Path.Combine(ReportsPath, PatientName);
        }
    }
}