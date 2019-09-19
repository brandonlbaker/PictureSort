using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class FolderBrowse : Form
    {
        public FolderBrowse()
        {
            InitializeComponent();
        }

        FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
        FolderBrowserDialog destination1 = new FolderBrowserDialog();
        FolderBrowserDialog destination2 = new FolderBrowserDialog();
        FolderBrowserDialog destination3 = new FolderBrowserDialog();
        FolderBrowserDialog destination4 = new FolderBrowserDialog();
        FolderBrowserDialog destination5 = new FolderBrowserDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFolderDialog.SelectedPath;          //Puts selected folder into text box
                listBox1.Items.Clear();

                string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
                }
            }
        }

        //Update PictureBox with image

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString());
        }

        //Setting Destination Folders

        private void openDestination1_Click(object sender, EventArgs e)
        {
            if (destination1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = destination1.SelectedPath;
            }
        }

        private void openDestination2_Click(object sender, EventArgs e)
        {
            if (destination2.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = destination2.SelectedPath;
            }
        }

        private void openDestination3_Click(object sender, EventArgs e)
        {
            if (destination3.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = destination3.SelectedPath;
            }
        }

        private void openDestination4_Click(object sender, EventArgs e)
        {
            if (destination4.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = destination4.SelectedPath;
            }
        }

        private void openDestination5_Click(object sender, EventArgs e)
        {
            if (destination5.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = destination5.SelectedPath;
            }
        }

        //Move selected picture to destination folder

        private void destinationButton1_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem == null) && !(destination1.SelectedPath == null)) {
                System.IO.File.Move(Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString()),
                    Path.Combine(destination1.SelectedPath.ToString(), listBox1.SelectedItem.ToString()));
            }

            //Reset listbox with updated contents
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
            }
        }

        private void destinationButton2_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem == null) && !(destination2.SelectedPath == null))
            {
                System.IO.File.Move(Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString()),
                    Path.Combine(destination2.SelectedPath.ToString(), listBox1.SelectedItem.ToString()));
            }

            //Reset listbox with updated contents
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
            }
        }

        private void destinationButton3_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem == null) && !(destination3.SelectedPath == null))
            {
                System.IO.File.Move(Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString()),
                    Path.Combine(destination3.SelectedPath.ToString(), listBox1.SelectedItem.ToString()));
            }

            //Reset listbox with updated contents
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
            }
        }

        private void destinationButton4_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem == null) && !(destination4.SelectedPath == null))
            {
                System.IO.File.Move(Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString()),
                    Path.Combine(destination4.SelectedPath.ToString(), listBox1.SelectedItem.ToString()));
            }

            //Reset listbox with updated contents
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
            }
        }

        private void destinationButton5_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedItem == null) && !(destination5.SelectedPath == null))
            {
                System.IO.File.Move(Path.Combine(openFolderDialog.SelectedPath.ToString(), listBox1.SelectedItem.ToString()),
                    Path.Combine(destination5.SelectedPath.ToString(), listBox1.SelectedItem.ToString()));
            }

            //Reset listbox with updated contents
            listBox1.Items.Clear();
            string[] files = Directory.GetFiles(openFolderDialog.SelectedPath);

            foreach (string file in files)
            {
                listBox1.Items.Add(Path.GetFileName(file));         //Populates listbox with file names
            }
        }
    }
}
