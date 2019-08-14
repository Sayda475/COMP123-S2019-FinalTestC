using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using COMP123_S2019_FinalTestC.Views;
/*
 * Student Name: Sayda Rahman
 * Student ID: 301042327
 * Description: This the  main form of the application
 * 
 */
namespace COMP123_S2019_FinalTestC.Views
{
    public partial class CharacterGenerationForm : MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
        /// <summary>
        /// This is the shared event handler for the AboutToolStripMenuItem and helpToolStripButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        } 
        
        /// <summary>
        /// This is the event handler for the ExitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This is the shared event handler for the OpenToolStripMenuItem and openMenuStripButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        public void OpenFileDialog()
        {
            //Configure the file dialog
            CharacterSheetOpenFileDialog.FileName = "Character";
            CharacterSheetOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetOpenFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            CharacterSheetOpenFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var _result = CharacterSheetOpenFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(CharacterSheetOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read stuff from the file into the Product object
                        //Program.product.productID = short.Parse(inputStream.ReadLine());
                        //Program.product.condition = inputStream.ReadLine();
                        //Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        //Program.product.platform = inputStream.ReadLine();
                        //Program.product.OS = inputStream.ReadLine();


                        //Cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //PopulateProductInfo();
        }
        /// <summary>
        /// This is the shared event handler for the SaveToolStripMenuItem and saveMenuStripButton click event
        /// This is the event handler for the SaveToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Configure the file dialog
            CharacterSheetSaveFileDialog.FileName = "Character";
            CharacterSheetSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSheetSaveFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            CharacterSheetSaveFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var _result = CharacterSheetSaveFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    //Open stream to write
                    using (StreamWriter outputStream = new StreamWriter(
                        File.Open(CharacterSheetSaveFileDialog.FileName, FileMode.Create)))
                    {
                        //Write stuff to the file
                        //outputStream.WriteLine(Program.product.productID.ToString());
                        //outputStream.WriteLine(Program.product.condition);
                        //outputStream.WriteLine(Program.product.cost);
                        //outputStream.WriteLine(Program.product.platform);
                        

                        //Cleanup
                        outputStream.Close();
                        outputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("File saved successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

    