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
        static Random random = new Random();
        public string generateFirstName;
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
        /// <summary>
        /// This is the shared event handler for the helpToolStripMenuItem and saveMenuStripButton click event
        /// This is the event handler for the helpToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }
        /// <summary>
        /// This the event handler for the GenerateNameButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            FirstNameDataLabel.Text = GenerateFirstName();
            LastNameDataLabel.Text = GenerateLastName();
            //CharacterNameTextBox.Text = FirstNameDataLabel.Text + " " + LastNameDataLabel.Text;
        }

        public string GenerateFirstName()
        {
            string[] firstNames = File.ReadAllLines("firstNames.txt");
            string firstName = firstNames[random.Next(firstNames.Length)];
            return firstName.ToString();
        }

        public string GenerateLastName()
        {
            string[] lastNames = File.ReadAllLines("lastNames.txt");
            string lastName = lastNames[random.Next(lastNames.Length)];
            return lastName.ToString();
        }

        private void GenerateSkillsButton_Click(object sender, EventArgs e)
        {
            AnimalDataLabel.Text = GenerateAnimal();
        }
        /// <summary>
        /// this is the method for skills on animal
        /// </summary>
        /// <returns></returns>
        public string GenerateAnimal()
        {
            string[] animals = File.ReadAllLines("skills.txt");
            string animal = animals[random.Next(animals.Length)];
            return animals.ToString();
        }
        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
    }
}

    