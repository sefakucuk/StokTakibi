using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarimMuhasebe.WinFormApp.Forms
{
    public partial class RaporForm : Form
    {
        public RaporForm(ReportDocument document)
        {
            InitializeComponent();
            cyristalReport.ReportSource = document;
        }
    }
}
