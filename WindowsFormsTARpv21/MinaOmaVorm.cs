﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTARpv21
{
    public partial class MinaOmaVorm : Form
    {
        TreeView puu;
        Button nupp;
        Label silt;
        public MinaOmaVorm()
        {
            Height = 600;
            Width = 900;
            Text = "Minu oma vorm koos elementidega";
            puu = new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new  Point(0, 0);
            TreeNode oksad=new TreeNode("elemendid");
            oksad.Nodes.Add( new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Silt-Label"));
            oksad.Nodes.Add(new TreeNode("Dialog aken-MessageBox"));


            puu.AfterSelect += Puu_AfterSelect;
            puu.Nodes.Add( oksad );
            this.Controls.Add(puu);
        }
        private void Puu_AfterSelect(object sender , TreeViewEventArgs e)
        {
            if(e.Node.Text == "Nupp-Button")
            {
                nupp=new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location = new Point(250, 100);
                nupp.Click += Nupp_Click;
                this.Controls.Add(nupp);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                silt = new Label
                {
                    Text = "Minu esimine vorm",
                    Size = new Size(200, 50),
                    Location = new Point(200, 0)
                };
                silt.MouseEnter += Silt_MouseEnter;
                silt.MouseLeave += Silt_MouseLeave;

                this.Controls.Add(silt);
            }
            else if (e.Node.Text == "Dialog aken-MessageBox")
            {
                MessageBox.Show("Aken", "Kõike lihtsam aken");
                var vastus = MessageBox.Show("Kas paneme aken kinni?","Valik",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vastus == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Töötavad");
                }
            }

        }

        private void Silt_MouseLeave(object sender, EventArgs e)
        {
            silt.ForeColor = Color.Black;
            silt.BackColor = Color.Transparent;
        }

        private void Silt_MouseEnter(object sender, EventArgs e)
        {
            silt.ForeColor = Color.White;
            silt.BackColor = Color.Black;
        }
        Random random=new Random();
        private void Nupp_Click(object sender, EventArgs e)
        {
            int red, green, blue;
            red=random.Next(255);
            green=random.Next(255);
            blue=random.Next(255);
            this.BackColor = Color.FromArgb(red, green, blue);

            //this.Close();
        }


    }
}
