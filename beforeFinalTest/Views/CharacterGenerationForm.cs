using beforeFinalTest.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
/*
 * STUDENT NAME: Thi Thu Ha Nguyen
 * ID: 301017727
 * DESCRIPTION: this is character generation form for load and display everything in 4 tabs
 */
namespace beforeFinalTest.Views
{
    public partial class CharacterGenerationForm : beforeFinalTest.Views.MasterForm
    {
        //create list fname,lastname
        List<string> FirstNameList;
        List<string> LastNameList;
        List<string> SkillList;
        /// <summary>
        /// This is method for reading file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static List<string> LoadNames(string fileName)
        {
            List<string> result = new List<string>();
            //read firstname
            TextReader reader = new StreamReader(fileName);
            string output = reader.ReadLine();
            while (output != null)
            {
                result.Add(output);
                output = reader.ReadLine();
            }
            reader.Close();
            reader.Dispose();
            return result;
        }

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
            if (MainTabControl.SelectedIndex != 0)
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
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
                if(MainTabControl.SelectedIndex==MainTabControl.TabPages.Count - 1)
                {
                    fnamedataLbl.Text = Program.chapo.Identity.FirstName;
                    lastnamedataLbl.Text = Program.chapo.Identity.LastName;

                    strengthdataLbl.Text = Program.chapo.Strength;
                    dexterydataLbl.Text = Program.chapo.Dexterity;
                    endurancedataLbl.Text = Program.chapo.Endurance;
                    intellectdataLbl.Text = Program.chapo.Intellect;
                    educationdataLbl.Text = Program.chapo.Education;
                    socialdataLbl.Text = Program.chapo.SocialStanding;

                    skill1dataLbl.Text = Program.chapo.SkillsList[0].Name;
                    skill2dataLbl.Text = Program.chapo.SkillsList[1].Name;
                    skill3dataLbl.Text = Program.chapo.SkillsList[2].Name;
                    skill4dataLbl.Text = Program.chapo.SkillsList[3].Name;


                }
            }
        }

        private void GenerateButon_Click(object sender, EventArgs e)
        {

            Random rd = new Random();
            Program.chapo.Identity.FirstName = LastNameList[rd.Next(0, LastNameList.Count - 1)];
            Program.chapo.Identity.LastName = FirstNameList[rd.Next(0, FirstNameList.Count - 1)];
            FNameDataLabel.Text = Program.chapo.Identity.FirstName;
            LNameDataLabel.Text = Program.chapo.Identity.LastName;
           
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutBox.ShowDialog();
        }

        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            FirstNameList = LoadNames("../../Data/firstNames.txt");
            LastNameList = LoadNames("../../Data/lastNames.txt");            
            SkillList =LoadNames("../../Data/skills.txt");
        }

        private void GenerateAbilityButton_Click(object sender, EventArgs e)
        {

            List<int> abilities = new List<int>();
            List<Label> labels = new List<Label>();

            //6 Text field
            Random rd = new Random();
            for (int i = 0; i < 6; i++)
            {
                abilities.Add(rd.Next(1, 15));
            }

            //6 Label
            labels.Add(StrengthDataLbel);
            labels.Add(DexrityDataLabel);
            labels.Add(EnduracneDataLabel);
            labels.Add(IntellectDataLabel);
            labels.Add(EducationDataLabel);
            labels.Add(SocialStandingDataLabel);            

            for (int i = 0; i < abilities.Count; i++)
            {
                labels[i].Text = abilities[i].ToString();
            }
            Program.chapo.Strength = StrengthDataLbel.Text;
            Program.chapo.Dexterity = DexrityDataLabel.Text;
            Program.chapo.Endurance = EnduracneDataLabel.Text;
            Program.chapo.Education = EducationDataLabel.Text;
            Program.chapo.Intellect = IntellectDataLabel.Text;
            Program.chapo.SocialStanding = SocialStandingDataLabel.Text;
        }

        private void GenerateSkillButton_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            
            skill1DataLabel.Text = SkillList[rd.Next(0, SkillList.Count - 1)];
            skill2DataLabel.Text = SkillList[rd.Next(0, SkillList.Count - 1)];
            skill3DataLabel.Text = SkillList[rd.Next(0, SkillList.Count - 1)];
            skill4DataLabel.Text = SkillList[rd.Next(0, SkillList.Count - 1)];

            Program.chapo.SkillsList.Add(new Skill(skill1DataLabel.Text));
            Program.chapo.SkillsList.Add(new Skill(skill2DataLabel.Text));
            Program.chapo.SkillsList.Add(new Skill(skill3DataLabel.Text));
            Program.chapo.SkillsList.Add(new Skill(skill4DataLabel.Text));

        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            CharacterSaveFileDialog.FileName = "character.txt";
            CharacterSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharacterSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open file dialog - Modal Form
            var result = CharacterSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open file to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(CharacterSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputStream.WriteLine(Program.chapo.Identity.FirstName);
                    outputStream.WriteLine(Program.chapo.Identity.LastName);
                    outputStream.WriteLine(Program.chapo.Strength);
                    outputStream.WriteLine(Program.chapo.Dexterity);
                    outputStream.WriteLine(Program.chapo.Endurance);
                    outputStream.WriteLine(Program.chapo.Education);
                    outputStream.WriteLine(Program.chapo.Intellect);
                    outputStream.WriteLine(Program.chapo.SocialStanding);
                    outputStream.WriteLine(Program.chapo.SkillsList.ToString());


                    // close the file
                    outputStream.Close();

                    // dispose of the memory
                    outputStream.Dispose();
                }

                MessageBox.Show("File Saved", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
}
