using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WINDOWS_FORM_APPLICATION_.NET_CORE
{
    public partial class SampleForm : Form
    {

        public SampleForm()
        {
            InitializeComponent();
        }

        private ConnectionStrings _connectionStrings =
            new ConnectionStrings();

        DatabaseContext databaseContext = null;

        private string _connection = null;
        private void SampleForm_Load(object sender, EventArgs e)
        {
            var configurationBuilder =
                         new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                      .SetBasePath(basePath: System.IO.Directory.GetCurrentDirectory())
                      .AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
                     // .AddUserSecrets("7f534107-fb55-4624-a532-51600b9fc404")
                      .AddUserSecrets(System.Reflection.Assembly.GetExecutingAssembly())
                      .Build()
                      ;

            configurationBuilder
                .GetSection(key: "ConnectionStrings")
                .Bind(instance: _connectionStrings)
                ;

            var builder =
                new SqlConnectionStringBuilder(
                    _connectionStrings.MyConnectionString);

            builder.Password =
                    configurationBuilder["DbPassword"];

            _connection = builder.ConnectionString;

            databaseContext =
               new DatabaseContext(connectionString: _connection);

        }
    }
}
