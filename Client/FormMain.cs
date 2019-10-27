using System;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        private static ServiceReference.TestServiceClient client;

        public FormMain()
        {
            InitializeComponent();

            comboBoxOperation.SelectedIndex = 0;

            try
            {
                client = new ServiceReference.TestServiceClient();
                client.Open();
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxOperation.SelectedIndex)
                {
                    case 0:
                        textBoxResult.Text = client.Add(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text)).ToString();
                        break;
                    case 1:
                        textBoxResult.Text = client.Subtract(int.Parse(textBoxA.Text), int.Parse(textBoxB.Text)).ToString();
                        break;
                    case 2:
                        textBoxResult.Text = client.Concatenate(textBoxA.Text, textBoxB.Text);
                        break;
                    default:
                        throw new Exception("Операция не поддерживается");
                }
            }
            catch (Exception error)
            {
                textBoxResult.Text = $"Ошибка: {error.Message}";
            }
        }
    }
}