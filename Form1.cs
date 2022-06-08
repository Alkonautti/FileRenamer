using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        private int startFrom = 0; //Used for numbering files in order
        public Form1()
        {
            InitializeComponent();
            lstbox_files.AllowDrop = true; //To enable drag and drop in list box
            txtbox_source.Enabled = false; //Disable source text box
        }

        private void btn_browse_Click(object sender, EventArgs e) //Browse folders
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtbox_source.Text = folderBrowserDialog1.SelectedPath; //Insert source folder path to source text box
            }
        }

        private void UpdateFilesList()
        {
            lstbox_files.Items.Clear(); //Clear list box everytime before updating it
            DirectoryInfo di = new DirectoryInfo(txtbox_source.Text); //DirectoryInfo path
            FileInfo[] fi = di.GetFiles(); //Get all files from current path and insert into FileInfo array

            foreach (FileInfo file in fi)
            {
                lstbox_files.Items.Add(file); //Add all files to list box
            }
            
        }

        private void txtbox_source_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtbox_source.Text)) //Before updating list box check if directory path exists
            {
                UpdateFilesList();
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            if (lstbox_files.SelectedItems.Count != 0 && txtbox_newname.Text != "") //Check that items has been selected and new name text box is not empty
            {
                Rename();
                UpdateFilesList();
            }
            else
            {
                MessageBox.Show("No new name or no files selected!"); //Display error message
            }
        }

        private void Rename()
        {
            startFrom = Convert.ToInt32(txtbox_startfrom.Text); //Convert start from string to integer

            foreach (FileInfo file in lstbox_files.SelectedItems) //Iterate over all seleted files
            {
                try
                {
                    string date = null;

                    if (chkbox_date.Checked) //If add date box has been checked
                    {
                        date += "_"; //Add underscore before date
                        date += DateTime.Today.ToString("dd/MM/yyyy"); //Get current date
                    }

                    else
                    {
                        date = ""; //If add date box is not checked, use empty string
                    }

                    string oldFile = txtbox_source.Text + @"\" + file.ToString(); //Build string for original path and file
                    string newFile = txtbox_source.Text + @"\" + txtbox_newname.Text + startFrom + date + Path.GetExtension(file.ToString()); //Build string for new path and file
                    File.Move(oldFile, newFile); //Use move to rename file
                    startFrom++; //Increment start numbering from number
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //Display error message
                }
            }
        }

        private void lstbox_files_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstbox_files.SelectedItem == null) //If dragging started from empty space in list box
            {
                return;
            }

            lstbox_files.DoDragDrop(lstbox_files.SelectedItem, DragDropEffects.Move); //Start dragging of item in list box
        }

        private void lstbox_files_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move; //Drag effect
        }

        private void lstbox_files_DragDrop(object sender, DragEventArgs e)
        {
            Point point = lstbox_files.PointToClient(new Point(e.X, e.Y)); //Get current mouse position inside list box
            int index = lstbox_files.IndexFromPoint(point); //If mouse is over list box item, get items index

            if (index < 0)
            {
                index = lstbox_files.Items.Count - 1;
            }

            object data = e.Data.GetData(typeof(FileInfo)); //Create object from list box item that is being dragged
            
            lstbox_files.Items.Remove(data); //Remove dragged item from original position
            lstbox_files.Items.Insert(index, data); //Add dragged item to new position
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit application
        }

        private void btn_selectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstbox_files.Items.Count; i++) //Iterate through list box items
            {
                lstbox_files.SetSelected(i, true); //Set current list box item to selected
            }
        }

        private void btn_selectnone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstbox_files.Items.Count; i++) //Iterate through list box items
            {
                lstbox_files.SetSelected(i, false); //De-select current list box item
            }
        }

        private void btn_removeitem_Click(object sender, EventArgs e)
        {
            if (lstbox_files.SelectedItems != null) //Check that item or items has been selected
            {
                foreach (FileInfo file in lstbox_files.SelectedItems.OfType<FileInfo>().ToList()) //Iterate through selected items
                {
                    lstbox_files.Items.Remove(file); //Remove current item
                }
            }
        }
    }
}
