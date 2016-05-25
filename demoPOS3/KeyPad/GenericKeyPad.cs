using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyPad
{
    public partial class GenericKeyPad: UserControl
    {
        public GenericKeyPad()
        {
            InitializeComponent();
        }

        public event KeyPressEventHandler ButtonPressed;

        public void RaiseButtonPressed(char WhatToSend)
        {
            KeyPressEventHandler handler = ButtonPressed;
            if(handler != null)
            {
                handler(this, new KeyPressEventArgs(WhatToSend));
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {

        }

        private void btn12_Click(object sender, EventArgs e)
        {

        }

        private void btn13_Click(object sender, EventArgs e)
        {

        }

        private void btn14_Click(object sender, EventArgs e)
        {

        }
    }
}
