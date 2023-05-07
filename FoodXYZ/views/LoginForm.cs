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
        private string currentUserInsideForm;
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
                    string delete = $"DELETE FROM user_season";
                    string currentUser;
                    DbManager.ExecuteQuery(log);
                    switch (userRole)
                    {
                        case "admin":
                            DbManager.ExecuteQuery(delete);
                            AdminForm adminForm = new AdminForm(username);
                            currentUserInsideForm = $"INSERT INTO user_season (username, form) VALUES ('{username}', 'admin')";
                            DbManager.ExecuteQuery(currentUserInsideForm);
                            adminForm.Show();
                            this.Hide();
                            break;
                        case "kasir":
                            DbManager.ExecuteQuery(delete);
                            TransaksiForm kasirForm = new TransaksiForm(username);
                            currentUserInsideForm = $"INSERT INTO user_season (username, form) VALUES ('{username}', 'kasir')";
                            DbManager.ExecuteQuery(currentUserInsideForm);
                            kasirForm.Show();
                            this.Hide();
                            break;
                        case "gudang":
                            DbManager.ExecuteQuery(delete);
                            BarangForm gudangForm = new BarangForm(username);
                            currentUserInsideForm = $"INSERT INTO user_season (username, form) VALUES ('{username}', 'gudang')";
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
