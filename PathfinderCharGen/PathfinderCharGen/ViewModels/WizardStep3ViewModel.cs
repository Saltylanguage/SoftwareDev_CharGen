using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;


namespace PathfinderCharGen.ViewModels
{

    public enum classEnum
    {
        Barbarian,
        Bard,
        Cleric,
        Druid,
        Fighter,
        Monk,
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        Wizard,
    }

    class WizardStep3ViewModel : ViewModelBase
    {    
        public WizardStep3ViewModel() { }
    }

    public class ClassImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                classEnum enumVal = classEnum.Barbarian;
                if(value.ToString() == "System.Windows.Controls.ComboBoxItem: Barbarian")
                {
                    enumVal = classEnum.Barbarian;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Bard")
                {
                    enumVal = classEnum.Bard;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Cleric")
                {
                    enumVal = classEnum.Cleric;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Druid")
                {
                    enumVal = classEnum.Druid;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Fighter")
                {
                    enumVal = classEnum.Fighter;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Monk")
                {
                    enumVal = classEnum.Monk;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Paladin")
                {
                    enumVal = classEnum.Paladin;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Ranger")
                {
                    enumVal = classEnum.Ranger;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Rogue")
                {
                    enumVal = classEnum.Rogue;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Sorcerer")
                {
                    enumVal = classEnum.Sorcerer;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Wizard")
                {
                    enumVal = classEnum.Wizard;
                }
                switch(enumVal)
                {
                    case classEnum.Barbarian:
                        return new BitmapImage(new Uri(@"../Resources/Barbarian.png", UriKind.Relative));
                    case classEnum.Bard:
                        return new BitmapImage(new Uri(@"../Resources/Bard.png", UriKind.Relative));
                    case classEnum.Cleric:
                        return new BitmapImage(new Uri(@"../Resources/Cleric.png", UriKind.Relative));
                    case classEnum.Druid:
                        return new BitmapImage(new Uri(@"../Resources/Druid.png", UriKind.Relative));
                    case classEnum.Fighter:
                        return new BitmapImage(new Uri(@"../Resources/Fighter.png", UriKind.Relative));
                    case classEnum.Monk:
                        return new BitmapImage(new Uri(@"../Resources/Monk.png", UriKind.Relative));
                    case classEnum.Paladin:
                        return new BitmapImage(new Uri(@"../Resources/Paladin.png", UriKind.Relative));
                    case classEnum.Ranger:
                        return new BitmapImage(new Uri(@"../Resources/Ranger.png", UriKind.Relative));
                    case classEnum.Rogue:
                        return new BitmapImage(new Uri(@"../Resources/Rogue.png", UriKind.Relative));
                    case classEnum.Sorcerer:
                        return new BitmapImage(new Uri(@"../Resources/Sorcerer.png", UriKind.Relative));
                    case classEnum.Wizard:
                        return new BitmapImage(new Uri(@"../Resources/Wizard.png", UriKind.Relative));
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


}

