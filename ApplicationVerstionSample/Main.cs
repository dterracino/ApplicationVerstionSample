using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationVerstionSample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            SetVersion();
        }

        private void SetVersion()
        { 

            var curAssembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(curAssembly.Location);

            var days = fileVersionInfo.FilePrivatePart;
            var buildDay = new DateTime(2010, 1, 1).AddDays(days);

            this.lVersionValue.Text = fileVersionInfo.FileVersion;
            this.lBuildOnValue.Text = buildDay.ToShortDateString();
        }
    }
}
