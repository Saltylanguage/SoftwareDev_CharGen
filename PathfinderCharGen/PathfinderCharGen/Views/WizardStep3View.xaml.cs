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
    /// Interaction logic for WizardStep3View.xaml
    /// </summary>
    public partial class WizardStep3View : UserControl
    {
        CharSheetView sheetView;

        public WizardStep3View(CharSheetView SV)
        {
            sheetView = SV;
            InitializeComponent();
        }

        private void Step3Next_Click(object sender, RoutedEventArgs e)
        {
            sheetView.CharacterClass.Text = ClassSelection.Text.ToString();
            this.Content = new WizardStep4View(sheetView);
        }
    }
}
