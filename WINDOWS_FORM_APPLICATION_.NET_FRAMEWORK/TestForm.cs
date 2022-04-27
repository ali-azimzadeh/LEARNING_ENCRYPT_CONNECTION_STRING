using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWS_FORM_APPLICATION_.NET_FRAMEWORK
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private string[] _port = 
            System.Configuration.ConfigurationManager
            .AppSettings.GetValues("Port");
        public string Port
        {
            get
            {
                if (string.IsNullOrEmpty(_port[0]) == false)
                {
                    return (_port[0]);
                }
                return (string.Empty);
            }
        }
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Port);
        }
    }
}
