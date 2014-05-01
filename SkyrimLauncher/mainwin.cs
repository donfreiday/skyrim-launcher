using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // for process class
using System.IO; //for file exist

namespace SkyrimLauncher
{
    public partial class mainwin : Form
    {
        public mainwin(bool autoLaunch)
        {
            InitializeComponent();

            //load favorites
            for (int i=0; i<Properties.Settings.Default.Favorites.Count; i++)
                favoritesListBox.Items.Add(Properties.Settings.Default.Favorites[i]);

            //default priority high
            priorityComboBox.SelectedIndex = 1; 

            //check default install dir for skyrim
            if (File.Exists(getProgFilesDir() + "\\The Elder Scrolls V Skyrim\\TESV.exe"))
                fileLocationTextbox.Text = getProgFilesDir() + "\\The Elder Scrolls V Skyrim\\TESV.exe";
            else
                fileLocationTextbox.Text = "Execute";

            //set button text
            if (File.Exists(fileLocationTextbox.Text))
                playButton.Text = "Execute " + Path.GetFileName(fileLocationTextbox.Text);

            statusLabel.Text = "Detected " + Environment.ProcessorCount + " cores. ";

            for (int i = 0; i < Environment.ProcessorCount; i++)
                coreListBox.Items.Add("Core " + i);

            if (Environment.ProcessorCount == 1)
            {
                coreListBox.SetItemChecked(0, true);
            }
            else if (Environment.ProcessorCount == 2)
            {
                coreListBox.SetItemChecked(0, true);
                coreListBox.SetItemChecked(1, true);
            }
            else if (Environment.ProcessorCount == 8)
            {
                coreListBox.SetItemChecked(0, true);
                coreListBox.SetItemChecked(6, true);
            }
            else
            {
                coreListBox.SetItemChecked(0, true);
                coreListBox.SetItemChecked(2, true);
            }

            //auto launch commandline switch
            if (autoLaunch)
                playButton_Click(this, new EventArgs());
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            fileLocationTextbox.Text = fileBrowser();
            playButton.Text = "Execute " + Path.GetFileName(fileLocationTextbox.Text);
        }

        /// <summary>
        /// Launch Skyrim (or any .exe) with priority and affinity set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playButton_Click(object sender, EventArgs e)
        {
            //check exe path
            if (!File.Exists(fileLocationTextbox.Text))
            {
                statusLabel.Text = "Error opening file.";
                return;
            }

            // get affinity
            int affinity = 0;
            int[] affinityBitMasks = { 0x0001, 0x0002, 0x0004, 0x0008, 0x00010, 0x00020, 0x00040, 0x0080 };//00000001,00000010,00000100,00001000,00010000,00100000,01000000,10000000
            for (int i = 0; i < coreListBox.Items.Count; i++)
                if (coreListBox.GetItemChecked(i))
                    affinity |= affinityBitMasks[i];
            if (affinity == 0) { statusLabel.Text = "You can't run on 0 cores."; return; }

            //launch process
            Process skyrim = new Process();
            skyrim.StartInfo.FileName = fileLocationTextbox.Text;
            skyrim.StartInfo.WorkingDirectory = (System.IO.Path.GetDirectoryName(skyrim.StartInfo.FileName));
            try
            {
                skyrim.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing", ex.Message, //or ex.tostring()
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //set affinity
            skyrim.ProcessorAffinity = (System.IntPtr)affinity;

            // set priority
            if (String.Compare(priorityComboBox.SelectedText, "Normal Priority", true) == 0)
                skyrim.PriorityClass = ProcessPriorityClass.Normal;
            else if (String.Compare(priorityComboBox.SelectedText, "Realtime Priority", true) == 0)
                skyrim.PriorityClass = ProcessPriorityClass.RealTime;
            else
                skyrim.PriorityClass = ProcessPriorityClass.High;
        }

        /// <returns>string with Program files (x86) directory</returns>
        static string getProgFilesDir()
        {
            if (8 == IntPtr.Size || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            return Environment.GetEnvironmentVariable("ProgramFiles");
        }

        /// <returns>File path as String</returns>
        static string fileBrowser()
        {
            OpenFileDialog browseFile = new OpenFileDialog();
            browseFile.Filter = "EXE Files (*.exe)|*.exe";
            browseFile.Title = "Browse For exe";
            browseFile.InitialDirectory = getProgFilesDir();
            if (browseFile.ShowDialog() == DialogResult.Cancel)
                return "Browse for exe";
            try
            {
                return browseFile.FileName;
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening file", "File Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return "Error";
        }

        //updates playButton with every text entered to box
        private void fileLocationTextbox_TextChanged(object sender, EventArgs e)
        {
            if ((File.Exists(fileLocationTextbox.Text))
                && (String.Compare(Path.GetExtension(fileLocationTextbox.Text), ".exe", true) == 0))
            {
                playButton.Text = "Execute " + Path.GetFileName(fileLocationTextbox.Text);
                displayIcon();
            }
            else
                playButton.Text = "Execute";
        }

        private void displayIcon()
        {
            iconBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Icon ico = Icon.ExtractAssociatedIcon(fileLocationTextbox.Text);
            iconBox.Image = (Image)ico.ToBitmap();
        }


        //following 3 functions control favorites list
        private void addFavoriteButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Favorites.Contains(fileLocationTextbox.Text))
                return;
            if ((File.Exists(fileLocationTextbox.Text))
               && (String.Compare(Path.GetExtension(fileLocationTextbox.Text), ".exe", true) == 0))
            {
                Properties.Settings.Default.Favorites.Add(fileLocationTextbox.Text);
                Properties.Settings.Default.Save();
                favoritesListBox.Items.Add(fileLocationTextbox.Text);
                favoritesListBox.Sorted = true;
            }
        }

        private void deleteFavoriteButton_Click(object sender, EventArgs e)
        {
            if (favoritesListBox.SelectedItems.Count != 0)
            {
                Properties.Settings.Default.Favorites.Remove(favoritesListBox.SelectedItem.ToString());
                Properties.Settings.Default.Save();

                favoritesListBox.Items.RemoveAt(favoritesListBox.SelectedIndex);
                if (favoritesListBox.Items.Count > 0)
                    favoritesListBox.SelectedIndex = 0;
            }
        }

        private void favoritesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (favoritesListBox.SelectedItems.Count != 0)
            {
                fileLocationTextbox.Text = favoritesListBox.SelectedItem.ToString();
            }
        }
        //end favorites handling
    }

}