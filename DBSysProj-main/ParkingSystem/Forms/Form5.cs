using ParkingSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem.Forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public void loadgrid()
        {
            Repositories userInfo = new Repositories();
            grid2.DataSource = userInfo.reserv1();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            loadgrid();

        }

        private void grid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
