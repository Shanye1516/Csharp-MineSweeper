﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 炸弹数量设置 : Form
    {
        public 炸弹数量设置()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numericUpDown1.Value.ToString());
            主窗体 fp = (主窗体)this.Owner;
            int length = fp.length;
            if (number >= length * length)
            {
                MessageBox.Show("炸弹数量过多，请重新设置！");
                return;
            }
            //fp.Show();
            this.Hide();
            fp.RestartGame(number, length);
            
        }

        private void 炸弹数量设置_Load(object sender, EventArgs e)
        {

        }

        private void 炸弹数量设置_FormClosed(object sender, FormClosedEventArgs e)
        {
            ////this.Close();
            try { this.Owner.Show(); }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
