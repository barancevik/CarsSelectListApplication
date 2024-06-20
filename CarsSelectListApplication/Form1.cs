using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace CarsSelectListApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (btnColor.BackColor!=colorDialog1.Color)
            {
                MessageBox.Show("Please choice car colour.");
            }
            else if (cbModel.SelectedIndex==-1)
            {
                MessageBox.Show("Please choice Model");
            }
            else if (cbEngineCapacity.SelectedIndex==-1)
            {
                MessageBox.Show("Please choice Engine Capacity");
            }
            else if (cbEngineType.SelectedIndex==-1)
            {
                MessageBox.Show("Please choice Engine Type");
            }
            else if (cbGear.SelectedIndex==-1)
            {
                MessageBox.Show("Please choice Gear Type");
            }
            else
            {

                ListViewItem Line = new ListViewItem();
                Line.UseItemStyleForSubItems = false;
                Line.Text = txtName.Text;
                Line.SubItems.Add(cbModel.Text);
                Line.SubItems.Add("");
                Line.SubItems[2].BackColor = btnColor.BackColor;
                Line.SubItems.Add(cbGear.Text);
                Line.SubItems.Add(cbEngineType.Text);
                Line.SubItems.Add(cbEngineCapacity.Text);

                listView1.Items.Add(Line);
                txtName.Clear();
                cbModel.SelectedIndex = -1;
                cbEngineCapacity.SelectedIndex = -1;
                cbEngineType.SelectedIndex = -1;
                cbGear.SelectedIndex = -1;
                txtName.Focus();

                //We call each line listviewitem.
                //The text property corresponds to the first column.
                //Since the first column is text, the other columns are designated as subitems.
                //New element item column > subitem

            }



        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult Result = colorDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;

            }



        }

        ListViewItem choiseline = new ListViewItem();
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string name = "";
            if (name=="")
            {
                choiseline = listView1.SelectedItems[0];
                txtName.Text = choiseline.Text;
                cbModel.Text = choiseline.SubItems[1].Text;
                btnColor.BackColor = choiseline.SubItems[2].BackColor;
                cbGear.Text = choiseline.SubItems[3].Text;
                cbEngineType.Text = choiseline.SubItems[4].Text;
                cbEngineCapacity.Text = choiseline.SubItems[5].Text;

            }

            else
            {
                MessageBox.Show("Successful");
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Should it be deleted?","Will be deleted", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                foreach (ListViewItem choiseline in listView1.SelectedItems)
                {
                    listView1.Items.Remove(choiseline);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            choiseline.Text = txtName.Text;
            choiseline.SubItems[1].Text = cbModel.Text;
            choiseline.SubItems[2].BackColor = btnColor.BackColor;
            choiseline.SubItems[3].Text = cbGear.Text;
            choiseline.SubItems[4].Text = cbEngineType.Text;
            choiseline.SubItems[5].Text = cbEngineCapacity.Text;


        }
    }
}
