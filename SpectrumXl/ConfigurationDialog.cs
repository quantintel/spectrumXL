using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpectrumXl;

namespace SpectrumXl
{
    public partial class ConfigurationDialog : Form
    {
        public static string host = "";

        public ConfigurationDialog()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            host = this.textBox1.Text;
            Date.host = host;
            DayCount.host = host;

            QuantIntelRibbon.configForm.Hide();
        }
    }
}
