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
    public partial class user_2 : Form
    {
        public user_2()
        {
            InitializeComponent();
        }

        private void gunaAdvenceTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton11_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton9_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceTileButton12_Click(object sender, EventArgs e)
        {

        }

        private void user_2_Load(object sender, EventArgs e)
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

        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
            Pay_mobile obj = new Pay_mobile();
            obj.Show();
            this.Hide();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceTileButton4_Click(object sender, EventArgs e)
        {
            Intranet obj = new Intranet();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceTileButton8_Click(object sender, EventArgs e)
        {
            Komunal obj = new Komunal();
            obj.Show();
            this.Hide();
        }
    }
}
