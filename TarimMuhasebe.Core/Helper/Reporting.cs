using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Core.Helper
{
    public class Reporting
    {
        private static readonly string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Tekno Sivas\Tarım Muhasebe\Raporlar";

        public static string GetAddress(string FileName)
        {
            return FolderPath + @"\" + FileName;
        }
    }
}
