using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fel.Enabled = false;
            le.Enabled = false;
            legfol.Enabled = false;
            legle.Enabled = false;
            torol.Enabled = false;
            jobbra.Enabled = false;

            fel2.Enabled = false;
            le2.Enabled = false;
            legfel2.Enabled = false;
            legle2.Enabled = false;
            torol2.Enabled = false;
            balra.Enabled = false;
        }

        private void hozaad1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void hozzaad2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                fel.Enabled = true;
                le.Enabled = true;
                legfol.Enabled = true;
                legle.Enabled = true;
                torol.Enabled = true;
                jobbra.Enabled = true;
            }
            if (listBox1.SelectedItem == null)
            {
                fel.Enabled = false;
                le.Enabled = false;
                legfol.Enabled = false;
                legle.Enabled = false;
                torol.Enabled = false;
                jobbra.Enabled = false;
            }
            if (listBox1.SelectedIndex < 1)
            {
                fel.Enabled = false;
                legfol.Enabled = false;
            }
            if (listBox1.SelectedIndex==listBox1.Items.Count-1)
            {
                le.Enabled = false;
                legle.Enabled = false;
            }
        }

        private void fel_Click(object sender, EventArgs e)
        {
            mozgat(-1);
        }

        private void mozgat(int irany)
        {
            int ujHely = listBox1.SelectedIndex + irany;
            object mostani = listBox1.SelectedItem;

            listBox1.Items.Remove(mostani);
            listBox1.Items.Insert(ujHely, mostani);
            listBox1.SetSelected(ujHely, true);
        }

        private void torol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void torol2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                fel2.Enabled = true;
                le2.Enabled = true;
                legfel2.Enabled = true;
                legle2.Enabled = true;
                torol2.Enabled = true;
                balra.Enabled = true;
            }
            if (listBox2.SelectedItem == null)
            {
                fel2.Enabled = false;
                le2.Enabled = false;
                legfel2.Enabled = false;
                legle2.Enabled = false;
                torol2.Enabled = false;
                balra.Enabled = false;
            }
            if (listBox2.SelectedIndex < 1)
            {
                fel2.Enabled = false;
                legfel2.Enabled = false;
            }
            if (listBox2.SelectedIndex == listBox2.Items.Count - 1)
            {
                le2.Enabled = false;
                legle2.Enabled = false;
            }
        }

        private void le_Click(object sender, EventArgs e)
        {
            mozgat(1);
        }

        private void legfol_Click(object sender, EventArgs e)
        {
            int ujHely = 0;
            object mostani = listBox1.SelectedItem;

            listBox1.Items.Remove(mostani);
            listBox1.Items.Insert(ujHely, mostani);
            listBox1.SetSelected(ujHely, true);
        }

        private void legle_Click(object sender, EventArgs e)
        {
            int ujHely = listBox1.Items.Count-1;
            object mostani = listBox1.SelectedItem;

            listBox1.Items.Remove(mostani);
            listBox1.Items.Insert(ujHely, mostani);
            listBox1.SetSelected(ujHely, true);
        }

        private void jobbra_Click(object sender, EventArgs e)
        {
            object kivalaszt = listBox1.SelectedItem;
            listBox2.Items.Add(kivalaszt);
            listBox1.Items.Remove(kivalaszt);
        }
        //masik oldal
        private void balra_Click(object sender, EventArgs e)
        {
            object kivalaszt = listBox2.SelectedItem;
            listBox1.Items.Add(kivalaszt);
            listBox2.Items.Remove(kivalaszt);
        }

        private void legfel2_Click(object sender, EventArgs e)
        {
            int ujHely = 0;
            object mostani = listBox2.SelectedItem;

            listBox2.Items.Remove(mostani);
            listBox2.Items.Insert(ujHely, mostani);
            listBox2.SetSelected(ujHely, true);
        }

        private void fel2_Click(object sender, EventArgs e)
        {
            mozgat2(-1);
        }

        private void mozgat2(int irany)
        {
            int ujHely = listBox2.SelectedIndex + irany;
            object mostani = listBox2.SelectedItem;

            listBox2.Items.Remove(mostani);
            listBox2.Items.Insert(ujHely, mostani);
            listBox2.SetSelected(ujHely, true);
        }

        private void le2_Click(object sender, EventArgs e)
        {
            mozgat2(1);
        }

        private void legle2_Click(object sender, EventArgs e)
        {
            int ujHely = listBox2.Items.Count - 1;
            object mostani = listBox2.SelectedItem;

            listBox2.Items.Remove(mostani);
            listBox2.Items.Insert(ujHely, mostani);
            listBox2.SetSelected(ujHely, true);
        }
    }
}
