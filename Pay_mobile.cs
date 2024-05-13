using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK
{
    public partial class Pay_mobile : Form
    {
        public Pay_mobile()
        {
            InitializeComponent();
        }

        private void Pay_mobile_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            user_1 obj = new user_1();
            obj.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            user_2 obj = new user_2();
            obj.Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            user_3 obj = new user_3();
            obj.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            user_4 obj = new user_4();
            obj.Show();
            this.Hide();
        }
    }
}
