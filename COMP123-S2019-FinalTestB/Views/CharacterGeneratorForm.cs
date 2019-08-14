using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Anamika Gora 
 * STUDENT ID: 30104413
 * DESCRIPTION: This is the Character Generator  Form - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
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
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This method will load the names
        /// </summary>
        public void LoadNames()
        {
            List<String> FirstNameList = FileDialog.ReadAllLines("C: \Users\301044113\Desktop\COMP123 - S2019 - FinalTestB - master");
            List<String> LastName = FileDialog.ReadAllLines("C:\Users\301044113\Desktop\COMP123-S2019-FinalTestB-master");
        }



        /// <summary>
        /// This  method will randomly pick up the names from the list
        /// </summary>
        public void generateNAmes()
        {

            Random rdm = new Random();

            String FName = FirstNameList[rdm.Next(FirstNameList.count)];
            String LName = LastNameList[rdm.Next(LastNameList.count)];
        }
    }
}
