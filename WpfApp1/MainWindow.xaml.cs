using System;
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

namespace Lab01Sydorova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int GetAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int ageThisYear = currentDate.Year-birthdate.Year;
            if(birthdate > currentDate.AddYears(-ageThisYear))
                ageThisYear--;
            return ageThisYear;

        }
        private string GetWesternZodi(DateTime birthdate)
        {
            switch (birthdate.Month)
            {
                case 1:
                    {
                        if (birthdate.Day < 21) return "Capricorn";
                        else return "Aquarius";
                    }
                case 2:
                    {
                        if (birthdate.Day < 20) return "Aquarius";
                        else return "Pisces";
                    }
                case 3:
                    {
                        if (birthdate.Day < 21) return "Pisces";
                        else return "Aries";
                    }
                case 4:
                    {
                        if (birthdate.Day < 21) return "Aries";
                        else return "Taurus";
                    }
                case 5:
                    {
                        if (birthdate.Day < 22) return "Taurus";
                        else return "Gemini";
                    }
                case 6:
                    {
                        if (birthdate.Day < 22) return "Gemini";
                        else return "Cancer";
                    }
                case 7:
                    {
                        if (birthdate.Day < 23) return "Cancer";
                        else return "Leo";
                    }
                case 8:
                    {
                        if (birthdate.Day < 22) return "Leo";
                        else return "Virgo";
                    }
                case 9:
                    {
                        if (birthdate.Day < 24) return "Virgo";
                        else return "Libra";
                    }
                case 10:
                    {
                        if (birthdate.Day < 24) return "Libra";
                        else return "Scorpio";
                    }
                case 11:
                    {
                        if (birthdate.Day < 24) return "Scorpio";
                        else return "Saggitarius";
                    }
                case 12:
                    {
                        if (birthdate.Day < 23) return "Saggitarius";
                        else return "Capricorn";
                    }
                default: return "Unknown";
            }
        }
        private string GetChinaZodi(DateTime birthdate)
        {
            switch((birthdate.Year - 4) % 12)
            {
                case 0:
                    {
                    return "Rat";
                }
                case 1:
                    {
                    return "Ox";
                }
                case 2:
                    {
                    return "Tiger";
                }
                case 3:
                    {
                    return "Rabbit";
                }
                case 4:
                    {
                    return "Dragon";
                }
                case 5:
                    {
                    return "Snake";
                }
                case 6:
                    {
                    return "Horse";
                }
                case 7:
                    {
                    return "Goat";
                }
                case 8:
                    {
                    return "Monkey";
                }
                case 9:
                    {
                    return "Rooster";
                }
                case 10:
                    {
                    return "Dog";
                }
                case 11:
                    {
                    return "Pig";
                }
                default: return "Unknown";
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (DateChooser.SelectedDate == null)
            { MessageBox.Show("Choose your birthday"); }
            else
            {
                int userAge = GetAge(birthdate: DateChooser.SelectedDate.Value);
                if ((userAge < 0) || (userAge > 135))
                { MessageBox.Show("Invalid Date"); }

                else
                {
                    if ((DateChooser.SelectedDate.Value.Month == DateTime.Now.Month) && (DateChooser.SelectedDate.Value.Day == DateTime.Now.Day))
                    { Age.Text = "My congratulations, you're already " + userAge + " y.o";
                        Age.FontSize = 12;
                    }

                    else
                    { Age.Text = "Your age: " + userAge; }

                    WesternZodi.Text = "Western Zodi: " + GetWesternZodi(DateChooser.SelectedDate.Value);
                    ChinaZodi.Text = "China Zodi: " + GetChinaZodi(DateChooser.SelectedDate.Value);
                }
            }

        }
    }
}
