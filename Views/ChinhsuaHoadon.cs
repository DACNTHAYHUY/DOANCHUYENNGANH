using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATN.Views
{
    public partial class ChinhsuaHoadon : Form
    {
        public ChinhsuaHoadon()
        {
            InitializeComponent();
        }
        public static String Mahd;
        Chitiethoadonbh_View cthdbv = new Chitiethoadonbh_View();
        public void Tacvu()
        {
            Mahd = txtMahdb.Text;
            Chitiethoadonbh_View.tt = 3;
            this.Hide();
            cthdbv.ShowDialog();
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Tacvu();
        }

        private void txtMahdb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Tacvu();
            }
        }
    }
}
