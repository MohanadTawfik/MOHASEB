using DevExpress.XtraGrid.Views.Grid;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace MOHASEB.Views.Components.InventoryManagment.Inputs
{
    public partial class Items : Control_Master
    {
        private MOHASEB_DBEntities db;

        public Items()
        {
            InitializeComponent();
            LoadDate();


         
        }

        // Load Date 
        public void LoadDate()
        {
            // Instantiate a new DataContext
            db = new MOHASEB.Model.MOHASEB_DBEntities();

          


        }
      
        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }
        // Add the statment here
        private void controlsButtons1_Load(object sender, EventArgs e)
        {
           




        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void controlsButtons1_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void chk_is_stop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_extra1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
