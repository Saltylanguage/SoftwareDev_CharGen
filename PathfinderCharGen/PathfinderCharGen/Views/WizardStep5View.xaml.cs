﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for WizardStep5View.xaml
    /// </summary>
    public partial class WizardStep5View : UserControl
    {

        CharSheetView sheetView;
        private int pointsRemaining = 0;
        List<CheckBox> Skills = new List<CheckBox>();

        public WizardStep5View()
        {
            InitializeComponent();
        }

        public WizardStep5View(CharSheetView SV)
        {
            sheetView = SV;
            InitializeComponent();
            POINTS.Text = (Convert.ToInt32(sheetView.INT_Mod.Text) + sheetView.character.statMgr.classMngr.Class.skillPoints).ToString();

            pointsRemaining = Convert.ToInt32(POINTS.Text);

            Skills.Add(Acrobatics_CHECKBOX);             //00
            Skills.Add(Appraise_CHECKBOX);               //01
            Skills.Add(Bluff_CHECKBOX);                  //02
            Skills.Add(Climb_CHECKBOX);                  //03
            Skills.Add(Craft_CHECKBOX);                  //04
            Skills.Add(Diplomacy_CHECKBOX);              //05
            Skills.Add(Disable_Device_CHECKBOX);         //06
            Skills.Add(Disguise_CHECKBOX);               //07
            Skills.Add(Escape_Artist_CHECKBOX);          //08
            Skills.Add(Fly_CHECKBOX);                    //09
            Skills.Add(Handle_Animal_CHECKBOX);          //10
            Skills.Add(Heal_CHECKBOX);                   //11
            Skills.Add(Intimidate_CHECKBOX);             //12
            Skills.Add(Linguistics_CHECKBOX);            //13
            Skills.Add(Perception_CHECKBOX);             //14
            Skills.Add(Perform_CHECKBOX);                //15
            Skills.Add(Profession_CHECKBOX);             //16
            Skills.Add(Ride_CHECKBOX);                   //17
            Skills.Add(Sense_Motive_CHECKBOX);           //18
            Skills.Add(Sleight_Of_Hand_CHECKBOX);        //19
            Skills.Add(Spellcraft_CHECKBOX);             //20
            Skills.Add(Stealth_CHECKBOX);                //21
            Skills.Add(Survival_CHECKBOX);               //22
            Skills.Add(Swim_CHECKBOX);                   //23
            Skills.Add(Use_Magic_Device_CHECKBOX);       //24

            Skills.Add(Arcana_CHECKBOX);                 //25
            Skills.Add(Dungeoneering_CHECKBOX);          //26
            Skills.Add(Engineering_CHECKBOX);            //27
            Skills.Add(Geography_CHECKBOX);              //28
            Skills.Add(History_CHECKBOX);                //29
            Skills.Add(Local_CHECKBOX);                  //30
            Skills.Add(Nature_CHECKBOX);                 //31
            Skills.Add(Nobility_CHECKBOX);               //32            
            Skills.Add(Planes_CHECKBOX);                 //33
            Skills.Add(Religion_CHECKBOX);               //34

        }

        private void Step5Next_Click(object sender, RoutedEventArgs e)
        {
         
            for (int i = 0; i < Skills.Count(); ++i)
            {

                int skillRank = 0;

                if (Skills[i].IsChecked == true)
                {
                    if (i == 0)
                    {
                        skillRank = Convert.ToInt32(sheetView.Acrobatics_Rank.Text);
                        skillRank++;
                        sheetView.Acrobatics_Rank.Text = skillRank.ToString();
                    }
                    if (i == 1)
                    {
                        skillRank = Convert.ToInt32(sheetView.Appraise_Rank.Text);
                        skillRank++;
                        sheetView.Appraise_Rank.Text = skillRank.ToString();
                    }
                    if (i == 2)
                    {
                        skillRank = Convert.ToInt32(sheetView.Bluff_Rank.Text);
                        skillRank++;
                        sheetView.Bluff_Rank.Text = skillRank.ToString();
                    }
                    if (i == 3)
                    {
                        skillRank = Convert.ToInt32(sheetView.Climb_Rank.Text);
                        skillRank++;
                        sheetView.Climb_Rank.Text = skillRank.ToString();
                    }
                    if (i == 4)
                    {
                        skillRank = Convert.ToInt32(sheetView.Craft_Rank.Text);
                        skillRank++;
                        sheetView.Craft_Rank.Text = skillRank.ToString();
                    }
                    if (i == 5)
                    {
                        skillRank = Convert.ToInt32(sheetView.Diplomacy_Rank.Text);
                        skillRank++;
                        sheetView.Diplomacy_Rank.Text = skillRank.ToString();
                    }
                    if (i == 6)
                    {
                        skillRank = Convert.ToInt32(sheetView.Disable_Device_Rank.Text);
                        skillRank++;
                        sheetView.Disable_Device_Rank.Text = skillRank.ToString();
                    }
                    if (i == 7)
                    {
                        skillRank = Convert.ToInt32(sheetView.Disguise_Rank.Text);
                        skillRank++;
                        sheetView.Disguise_Rank.Text = skillRank.ToString();
                    }
                    if (i == 8)
                    {
                        skillRank = Convert.ToInt32(sheetView.Escape_Artist_Rank.Text);
                        skillRank++;
                        sheetView.Escape_Artist_Rank.Text = skillRank.ToString();
                    }
                    if (i == 9)
                    {
                        skillRank = Convert.ToInt32(sheetView.Fly_Rank.Text);
                        skillRank++;
                        sheetView.Fly_Rank.Text = skillRank.ToString();
                    }
                    if (i == 10)
                    {
                        skillRank = Convert.ToInt32(sheetView.Handle_Animal_Rank.Text);
                        skillRank++;
                        sheetView.Handle_Animal_Rank.Text = skillRank.ToString();
                    }
                    if (i == 11)
                    {
                        skillRank = Convert.ToInt32(sheetView.Heal_Rank.Text);
                        skillRank++;
                        sheetView.Heal_Rank.Text = skillRank.ToString();
                    }
                    if (i == 12)
                    {
                        skillRank = Convert.ToInt32(sheetView.Intimidate_Rank.Text);
                        skillRank++;
                        sheetView.Intimidate_Rank.Text = skillRank.ToString();
                    }
                    if (i == 13)
                    {
                        skillRank = Convert.ToInt32(sheetView.Linguistics_Rank.Text);
                        skillRank++;
                        sheetView.Linguistics_Rank.Text = skillRank.ToString();
                    }
                    if (i == 14)
                    {
                        skillRank = Convert.ToInt32(sheetView.Perception_Rank.Text);
                        skillRank++;
                        sheetView.Perception_Rank.Text = skillRank.ToString();
                    }
                    if (i == 15)
                    {
                        skillRank = Convert.ToInt32(sheetView.Perform_Rank.Text);
                        skillRank++;
                        sheetView.Perform_Rank.Text = skillRank.ToString();
                    }
                    if (i == 16)
                    {
                        skillRank = Convert.ToInt32(sheetView.Profession_Rank.Text);
                        skillRank++;
                        sheetView.Profession_Rank.Text = skillRank.ToString();
                    }
                    if (i == 17)
                    {
                        skillRank = Convert.ToInt32(sheetView.Ride_Rank.Text);
                        skillRank++;
                        sheetView.Ride_Rank.Text = skillRank.ToString();
                    }
                    if (i == 18)
                    {
                        skillRank = Convert.ToInt32(sheetView.Sense_Motive_Rank.Text);
                        skillRank++;
                        sheetView.Sense_Motive_Rank.Text = skillRank.ToString();
                    }
                    if (i == 19)
                    {
                        skillRank = Convert.ToInt32(sheetView.Sleight_Of_Hand_Rank.Text);
                        skillRank++;
                        sheetView.Sleight_Of_Hand_Rank.Text = skillRank.ToString();
                    }
                    if (i == 20)
                    {
                        skillRank = Convert.ToInt32(sheetView.Spellcraft_Rank.Text);
                        skillRank++;
                        sheetView.Spellcraft_Rank.Text = skillRank.ToString();
                    }
                    if (i == 21)
                    {
                        skillRank = Convert.ToInt32(sheetView.Stealth_Rank.Text);
                        skillRank++;
                        sheetView.Stealth_Rank.Text = skillRank.ToString();
                    }
                    if (i == 22)
                    {
                        skillRank = Convert.ToInt32(sheetView.Survival_Rank.Text);
                        skillRank++;
                        sheetView.Survival_Rank.Text = skillRank.ToString();
                    }
                    if (i == 23)
                    {
                        skillRank = Convert.ToInt32(sheetView.Swim_Rank.Text);
                        skillRank++;
                        sheetView.Swim_Rank.Text = skillRank.ToString();
                    }
                    if (i == 24)
                    {
                        skillRank = Convert.ToInt32(sheetView.Use_Magic_Device_Rank.Text);
                        skillRank++;
                        sheetView.Use_Magic_Device_Rank.Text = skillRank.ToString();
                    }

                    if (i == 25)
                    {
                        skillRank = Convert.ToInt32(sheetView.Arcana_Rank.Text);
                        skillRank++;
                        sheetView.Arcana_Rank.Text = skillRank.ToString();
                    }
                    if (i == 26)
                    {
                        skillRank = Convert.ToInt32(sheetView.Dungeoneering_Rank.Text);
                        skillRank++;
                        sheetView.Dungeoneering_Rank.Text = skillRank.ToString();
                    }
                    if (i == 27)
                    {
                        skillRank = Convert.ToInt32(sheetView.Engineering_Rank.Text);
                        skillRank++;
                        sheetView.Engineering_Rank.Text = skillRank.ToString();
                    }
                    if (i == 28)
                    {
                        skillRank = Convert.ToInt32(sheetView.Geography_Rank.Text);
                        skillRank++;
                        sheetView.Geography_Rank.Text = skillRank.ToString();
                    }
                    if (i == 29)
                    {
                        skillRank = Convert.ToInt32(sheetView.History_Rank.Text);
                        skillRank++;
                        sheetView.History_Rank.Text = skillRank.ToString();
                    }
                    if (i == 30)
                    {
                        skillRank = Convert.ToInt32(sheetView.Local_Rank.Text);
                        skillRank++;
                        sheetView.Local_Rank.Text = skillRank.ToString();
                    }
                    if (i == 31)
                    {
                        skillRank = Convert.ToInt32(sheetView.Nature_Rank.Text);
                        skillRank++;
                        sheetView.Nature_Rank.Text = skillRank.ToString();
                    }
                    if (i == 32)
                    {
                        skillRank = Convert.ToInt32(sheetView.Nobility_Rank.Text);
                        skillRank++;
                        sheetView.Nobility_Rank.Text = skillRank.ToString();
                    }
                    if (i == 33)
                    {
                        skillRank = Convert.ToInt32(sheetView.Planes_Rank.Text);
                        skillRank++;
                        sheetView.Planes_Rank.Text = skillRank.ToString();
                    }
                    if (i == 34)
                    {
                        skillRank = Convert.ToInt32(sheetView.Religion_Rank.Text);
                        skillRank++;
                        sheetView.Religion_Rank.Text = skillRank.ToString();
                    }
                }
            }

            sheetView.setClassTab();

            Window parentWindow = Window.GetWindow(this);
            Window window = new Window { Content = sheetView, Height = 1010, Width = 1800, WindowStartupLocation = WindowStartupLocation.CenterScreen };

            sheetView.CalcBtn.Command.Execute(sheetView);

            parentWindow.Close();
            window.ShowDialog();
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            pointsRemaining--;
            POINTS.Text = pointsRemaining.ToString();

            if (pointsRemaining <= 0)
            {
                for (int i = 0; i < Skills.Count(); ++i)
                {
                    if (Skills[i].IsChecked == false)
                    {
                        Skills[i].IsEnabled = false;
                    }
                }
            }
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            pointsRemaining++;
            POINTS.Text = pointsRemaining.ToString();

            if (pointsRemaining >= 0)
            {

                for (int i = 0; i < Skills.Count(); ++i)
                {
                    Skills[i].IsEnabled = true;
                }
            }
        }
    }
}
