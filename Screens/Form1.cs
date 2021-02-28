using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Spammer {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
        }



        private void Form1_Load (object sender, EventArgs e) {
        }


        public string user_input;

        private void btn_start_Click (object sender, EventArgs e) {
            timer1.Start();
        }

        private void btn_stop_Click (object sender, EventArgs e) {
            timer1.Stop();
        }

        private void timer1_Tick (object sender, EventArgs e) {
            SendKeys.Send(user_input);
            SendKeys.Send("{ENTER}");
        }

        private void TB1_TextChanged (object sender, EventArgs e) {
            user_input = TB1.Text;
        }
    }
}
