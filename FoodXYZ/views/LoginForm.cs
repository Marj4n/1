using FoodXYZ.db;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.views
{
    public partial class LoginForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public LoginForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                               MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700,
                                              MaterialSkin.Primary.Blue100, MaterialSkin.Accent.LightBlue200,
                                                             MaterialSkin.TextShade.WHITE);
        }

        private void login()
        {
            string username = usernameMaskedTextBox.Text;
            string password = passwordMaskedTextBox.Text;

            string account = DbManager.ExecuteQuery($"SELECT * FROM user WHERE username = '{username}' AND password = '{password}'");
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password is empty!");
            }
            else
            {


                if (string.IsNullOrEmpty(account))
                {
                    MessageBox.Show("Username or password is incorrect!");
                }
                else
                {
                    string userRole = DbManager.ExecuteQuery($"SELECT tipe_user FROM user WHERE username = '{username}' AND password = '{password}'");

                    string log = $"INSERT INTO log (waktu, aktivitas, id_user) VALUES (NOW(), 'login', (SELECT id FROM user WHERE username = '{username}'))";
                    DbManager.ExecuteQuery(log);
                    switch (userRole)
                    {
                        case "admin":
                            AdminForm adminForm = new AdminForm(username);
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "kasir":
                            TransaksiForm kasirForm = new TransaksiForm(username);
                            kasirForm.Show();
                            this.Hide();
                            break;
                        case "gudang":
                            BarangForm gudangForm = new BarangForm(username);
                            gudangForm.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User role not found!");
                            break;
                    }
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           login();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            usernameMaskedTextBox.Text = "";
            passwordMaskedTextBox.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
