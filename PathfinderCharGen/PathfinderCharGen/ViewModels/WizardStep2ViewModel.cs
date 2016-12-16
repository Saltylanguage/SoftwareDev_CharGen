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

    public enum raceEnum
    {
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        HalfOrc,
        Halfling,
        Human,
    }

    class WizardStep2ViewModel : ViewModelBase
    {
        public WizardStep2ViewModel() { }
    }

    public class RaceImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                raceEnum enumVal = raceEnum.Dwarf;
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Dwarf")
                {
                    enumVal = raceEnum.Dwarf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Elf")
                {
                    enumVal = raceEnum.Elf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Gnome")
                {
                    enumVal = raceEnum.Gnome;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Half-Elf")
                {
                    enumVal = raceEnum.HalfElf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Half-Orc")
                {
                    enumVal = raceEnum.HalfOrc;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Halfling")
                {
                    enumVal = raceEnum.Halfling;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Human")
                {
                    enumVal = raceEnum.Human;
                }
                switch (enumVal)
                {
                    case raceEnum.Dwarf:
                        return new BitmapImage(new Uri(@"../Resources/dwarf.png", UriKind.Relative));
                    case raceEnum.Elf:
                        return new BitmapImage(new Uri(@"../Resources/elf.png", UriKind.Relative));
                    case raceEnum.Gnome:
                        return new BitmapImage(new Uri(@"../Resources/gnome.png", UriKind.Relative));
                    case raceEnum.HalfElf:
                        return new BitmapImage(new Uri(@"../Resources/halfelf.png", UriKind.Relative));
                    case raceEnum.HalfOrc:
                        return new BitmapImage(new Uri(@"../Resources/halforc2.png", UriKind.Relative));
                    case raceEnum.Halfling:
                        return new BitmapImage(new Uri(@"../Resources/haflling.png", UriKind.Relative));
                    case raceEnum.Human:
                        return new BitmapImage(new Uri(@"../Resources/human.png", UriKind.Relative));
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


