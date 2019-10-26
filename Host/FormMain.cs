using Service;
using System;
using System.Drawing;
using System.ServiceModel;
using System.Windows.Forms;

namespace Host
{
    public partial class FormMain : Form
    {
        private static ServiceHost host;

        public FormMain()
        {
            InitializeComponent();

            try
            {
                host = new ServiceHost(typeof(TestService));
                host.Open();
                labelStatus.Text = "Сервис успешно запущен и работает";
                labelStatus.ForeColor = Color.MediumSpringGreen;
            }
            catch (Exception error)
            {
                labelStatus.ForeColor = Color.Crimson;
                labelStatus.Text = $"Не удалось запустить сервис: {error.Message}";
            }
        }
    }
}