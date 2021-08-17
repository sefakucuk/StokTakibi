using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Core.Helper
{
    public class Setting
    {
        public static readonly string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Tekno Sivas\Tarım Muhasebe\Ayarlar";

        public static string GetAddress(string FileName)
        {
            return FolderPath + @"\" + FileName;
        }
    }
}
