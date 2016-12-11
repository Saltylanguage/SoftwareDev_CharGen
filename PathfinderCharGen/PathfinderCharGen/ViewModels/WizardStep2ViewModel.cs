﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace PathfinderCharGen.ViewModels
{

    public enum MyEnum
    {
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        HalfOrc,
        Halfling,
        Human,
        Nothing
    }

    class WizardStep2ViewModel : ViewModelBase
    {

        public IEnumerable<MyEnum> MyProperty
        {
            get { return Enum.GetValues(typeof(MyEnum)).Cast<MyEnum>(); }
        }

        public WizardStep2ViewModel() { }
    }

    public class EnumToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                MyEnum enumVal = MyEnum.Dwarf;
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Dwarf")
                {
                    enumVal = MyEnum.Dwarf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Elf")
                {
                    enumVal = MyEnum.Elf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Gnome")
                {
                    enumVal = MyEnum.Gnome;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Half-Elf")
                {
                    enumVal = MyEnum.HalfElf;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Half-Orc")
                {
                    enumVal = MyEnum.HalfOrc;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Halfling")
                {
                    enumVal = MyEnum.Halfling;
                }
                if (value.ToString() == "System.Windows.Controls.ComboBoxItem: Human")
                {
                    enumVal = MyEnum.Human;
                }

                if (value != null)
                {
                    switch (enumVal)
                    {
                        case MyEnum.Dwarf:
                            return new BitmapImage(new Uri(@"../Resources/dwarf.png", UriKind.Relative));
                        case MyEnum.Elf:
                            return new BitmapImage(new Uri(@"../Resources/elf.png", UriKind.Relative));
                        case MyEnum.Gnome:
                            return new BitmapImage(new Uri(@"../Resources/gnome.png", UriKind.Relative));
                        case MyEnum.HalfElf:
                            return new BitmapImage(new Uri(@"../Resources/halfelf.png", UriKind.Relative));
                        case MyEnum.HalfOrc:
                            return new BitmapImage(new Uri(@"../Resources/halforc2.png", UriKind.Relative));
                        case MyEnum.Halfling:
                            return new BitmapImage(new Uri(@"../Resources/haflling.png", UriKind.Relative));
                        case MyEnum.Human:
                            return new BitmapImage(new Uri(@"../Resources/human.png", UriKind.Relative));
                    }
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

