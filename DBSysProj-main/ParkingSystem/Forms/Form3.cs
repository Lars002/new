using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingSystem.Appdata;
using ParkingSystem.Forms;
using ParkingSystem.Repository;

namespace ParkingSystem
{
   

    public partial class Form3 : Form
    {
        ParkingSystemEntities db;
        Repositories repo;
        int slotId;
        public Form3()
        {
            InitializeComponent();
            db = new ParkingSystemEntities();
            repo = new Repositories();
        }
        private void loadVehicletype()
        {
            using (db = new ParkingSystemEntities())
            {
                var vehicles = db.Vehicle.ToList();

                cbType.ValueMember = "id";
                cbType.DisplayMember = "VehicleType";
                cbType.DataSource = vehicles;


            }
        }

        private void loadFloor()
        {
            //using (db = new ParkingSystemEntities())
            //{
            //    var items = db.slotItems.ToList();

            //    cbType.ValueMember = "id";
            //    cbType.DisplayMember = "";
            //    cbType.DataSource = items;


            //}
        }


        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void loadgrid()
        {
            Repositories userInfo = new Repositories();
            dataGridView1.DataSource = repo.getSlot();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadVehicletype();
            loadgrid();
            //loadFloor();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (db = new ParkingSystemEntities())
            {
                if (String.IsNullOrEmpty(txtPlate.Text))
                {
                    errorProvider1.SetError(txtPlate, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(cbType.Text))
                {
                    errorProvider1.SetError(cbType, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(txtPayment.Text))
                {
                    errorProvider1.SetError(txtPayment, "Empty Field");
                    return;
                }
                if (String.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    errorProvider1.SetError(dateTimePicker1, "Empty Field");
                    return;
                }




                Reservation reserv = new Reservation();
                reserv.plateNo = Convert.ToInt32(txtPlate.Text);
                reserv.VehicleType = cbType.Text;
                reserv.OwnerName = txtName.Text;
                reserv.Payment = Convert.ToInt32(txtPayment.Text);
                reserv.date = dateTimePicker1.Value;
                //reserv.slotId = slotId;
                //reserv.isApproved = "Not Approved";
                
                SlotTable slot  = new SlotTable();



                db.Reservation.Add(reserv);
                db.SaveChanges();



               

                txtPlate.Clear();
                cbType.SelectedIndex = 0;
                txtPlate.Clear();
                txtName.Clear();
                txtPayment.Clear();
                MessageBox.Show("Reserved Done!");

            }
            new Form5().Show();
            this.Hide();

            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //slotId = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            //slotNumber = dataGridView1.Rows[e.RowIndex].Cells["slotNumber"].Value.ToString();
            //floorNumber = dataGridView1.Rows[e.RowIndex].Cells["floorNumber"].Value.ToString();
        }
    }
}
