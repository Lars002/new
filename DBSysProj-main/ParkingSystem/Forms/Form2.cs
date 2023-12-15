using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingSystem.Appdata;

namespace ParkingSystem
{
    public partial class Form2 : Form
    {
        ParkingSystemEntities db;
        string gender;
        public Form2()
        {
            InitializeComponent();
            db = new ParkingSystemEntities();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPhoneNum.Text))
            {
                errorProvider1.SetError(txtPhoneNum, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Empty field");
                return;
            }
            if (rbMale.Checked == true)
            {
                rbFemale.Checked = false;
                gender = "Male";
            }
            if (rbFemale.Checked == true)
            {
                rbMale.Checked = false;
                gender = "Female";
            }

            Users nUser = new Users();
            nUser.Name = txtName.Text;
            nUser.userGender = gender;
            nUser.userPhone = txtPhoneNum.Text;
            nUser.userEmail = txtEmail.Text;
            nUser.userAddress = txtAddress.Text;
            nUser.userName = txtUsername.Text;
            nUser.userPass = txtPass.Text;

            db.Users.Add(nUser);
            db.SaveChanges();

            txtName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtPhoneNum.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            txtPass.Clear();
            MessageBox.Show("Registered!");
        }


        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            showPassword = !showPassword;


            if (showPassword)
            {
                txtPass.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                textBox2.PasswordChar= '*';
            }

        }
        private Boolean showPassword = false;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }

}
