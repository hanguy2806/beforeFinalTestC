using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
 * STUDENT NAME:
 * ID:
 * DESCRIPTION:
 */
namespace beforeFinalTest.Views
{
    public partial class CharacterGenerationForm : beforeFinalTest.Views.MasterForm
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// THIS IS EVENT HANDLER FOR BACK BTN
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
        /// THIS IS FOR NEXT BTN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }

        }

        
    }
}
