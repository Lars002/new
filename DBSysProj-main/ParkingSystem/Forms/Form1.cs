using ParkingSystem.Forms;
using ParkingSystem.Model;
using ParkingSystem.Repository;
using ParkingSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class Form1 : Form
    {
        private object button1;
        Repositories repo;

        public Form1()
        {
            InitializeComponent();
            repo = new Repositories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            showPassword = !showPassword;


            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
        private Boolean showPassword;

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProviderCustom.SetError(txtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderCustom.SetError(txtPassword, "Empty Field!");
                return;
            }

            var userLogged = repo.GetUserByUsername(txtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.userPass.Equals(txtPassword.Text)) 
                {
                    UserLogged.GetInstance().Users = userLogged;

                    switch ((Roles)userLogged.roleId)
                    {
                        case Roles.User:
                            new Form3().Show();
                            this.Hide();
                            break;
                        case Roles.Staff:
                            new frmStaff().Show();
                            this.Hide();
                            break;
                        case Roles.Admin:
                            new Form3().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
            }
        }
    }
}
