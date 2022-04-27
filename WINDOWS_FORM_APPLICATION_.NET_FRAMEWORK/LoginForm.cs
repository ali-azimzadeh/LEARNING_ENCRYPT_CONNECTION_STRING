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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var secureConnectionString = 
                new SecureConnectionString();

            secureConnectionString
                .Encription(app_ConfigPathName: Application.ExecutablePath);

            MessageBox.Show("Encrypted Successfully!");

            //Do Somthings...

            //کدهای مربوطه به لاگین را اینجا می نویسیم
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var secureAppSettings = new SecureAppSettings();

            secureAppSettings
                .Encription(app_ConfigPathName: Application.ExecutablePath);

            //Do Somthing...
        }
    }
}
