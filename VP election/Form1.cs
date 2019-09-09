using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_election
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vp_siang=0, vp_eycee=0;
        //NCP2103 - TEST COMMIT
        private void button1_Click(object sender, EventArgs e)
        {
           
                if ( maskedTextBox1.MaskCompleted && (radioButton1.Checked || radioButton2.Checked
    ))
                {
                    if (radioButton1.Checked)
                    {
                        string[] row = { maskedTextBox1.Text, radioButton1.Text };
                        ListViewItem item = new ListViewItem(row);
                        listView1.Items.Add(item);
                        MessageBox.Show("Your vote has been cast.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else if(radioButton2.Checked)
                    {
                        string[] row = { maskedTextBox1.Text, radioButton2.Text };
                        ListViewItem item = new ListViewItem(row);
                            listView1.Items.Add(item);
                        MessageBox.Show("Your vote has been cast.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                }
                else
                {
                    MessageBox.Show("Fill out all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            maskedTextBox1.Text = null;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                maskedTextBox1.Focus();

            }
        

        private void label1_Click(object sender, EventArgs e)
        {
            vp_siang = 0;
            vp_eycee = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                if(item.SubItems[1].Text == "James Michael Sianghio")
                {
                    vp_siang++; 
                }
                else if (item.SubItems[1].Text == "Eycee Cay Muñoz")
                {
                    vp_eycee++;
                    
                }            }
            MessageBox.Show("Election Results: \nJames Michael Sianghio: " + vp_siang.ToString() + "\nEycee Cay Muñoz: " + vp_eycee.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Alay na guys");
        }
    }
}
