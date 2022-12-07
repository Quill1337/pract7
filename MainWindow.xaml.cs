using System;
using System.Windows;

namespace WPFApp7_9_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Time time1 = new Time();
        Time time2 = new Time();
        Time time3 = new Time();

        public MainWindow()
        {
            InitializeComponent();
            firstValTriad1.Focus();
            DisableTextBox.IsChecked = true;
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ShowTask_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31\nИспользовать класс Triad (тройка нечетных чисел).\nОпределить производный класс Time с полями: час, минута и секунда.\nОпределить полный набор методов сравнения моментов времени");
        }


        private void ResBox_Click(object sender, RoutedEventArgs e)
        {
            if (DisableTextBox.IsChecked == true)
            {
                try
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1.Compare(time1, time2))
                    {
                        MessageBox.Show("Двойка равна", "Результат");
                    }
                    else
                    {
                        MessageBox.Show("Двойка не равна");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
            else
            {
                try
                {

                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1.Compare(time1, time2, time3))
                    {
                        MessageBox.Show("Тройка равна");
                    }
                    else
                    {
                        MessageBox.Show("Тройка не равна");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }

        private void DisableTextBox_Checked(object sender, RoutedEventArgs e)
        {
            ThirTriad.IsEnabled = false;
        }

        private void DisableTextBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ThirTriad.IsEnabled = true;
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            firstValTriad3.Clear();
            secValTriad3.Clear();
            thirValTriad3.Clear();

            firstValTriad2.Clear();
            secValTriad2.Clear();
            thirValTriad2.Clear();

            firstValTriad1.Clear();
            secValTriad1.Clear();
            thirValTriad1.Clear();

            firstValTriad1.Focus();
        }

        private void EqualityBut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DisableTextBox.IsChecked == true)
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1 == time2)
                    {
                        MessageBox.Show("Первая и вторая тройка равны");
                    }
                    else
                    {
                        MessageBox.Show("Первая и вторая тройка не равны");
                    }
                }
                else
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1 == time2 && time2 == time3)
                    {
                        MessageBox.Show("Первая, вторая и третья тройка равны");
                    }
                    else
                    {
                        MessageBox.Show("Первая, вторая и третья тройка не равны");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void GetTriads(bool check)
        {

            if (check)
            {
                int.TryParse(firstValTriad1.Text, out int firValTriad1);
                int.TryParse(secValTriad1.Text, out int seclTriad1);
                int.TryParse(thirValTriad1.Text, out int thirTriad1);

                time1.Seconds = firValTriad1;
                time1.Minutes = seclTriad1;
                time1.Hours = thirTriad1;


                int.TryParse(firstValTriad2.Text, out int firValTrd2);
                int.TryParse(secValTriad2.Text, out int secValTrd2);
                int.TryParse(thirValTriad2.Text, out int thirValTrd2);

                time2.Seconds = firValTrd2;
                time2.Minutes = secValTrd2;
                time2.Hours = thirValTrd2;

            }
            else
            {
                int.TryParse(firstValTriad1.Text, out int firValTriad1);
                int.TryParse(secValTriad1.Text, out int seclTriad1);
                int.TryParse(thirValTriad1.Text, out int thirTriad1);

                time1.Seconds = firValTriad1;
                time1.Minutes = seclTriad1;
                time1.Hours = thirTriad1;


                int.TryParse(firstValTriad2.Text, out int firValTrd2);
                int.TryParse(secValTriad2.Text, out int secValTrd2);
                int.TryParse(thirValTriad2.Text, out int thirValTrd2);

                time2.Seconds = firValTrd2;
                time2.Minutes = secValTrd2;
                time2.Hours = thirValTrd2;

                int.TryParse(firstValTriad3.Text, out int firValTrd3);
                int.TryParse(secValTriad3.Text, out int secValTrd3);
                int.TryParse(thirValTriad3.Text, out int thirValTrd3);

                time3.Seconds = firValTrd3;
                time3.Minutes = secValTrd3;
                time3.Hours = thirValTrd3;

            }

        }

        private void ParityBut_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DisableTextBox.IsChecked == true)
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1) { MessageBox.Show("Первая тройка нечетная"); } else { MessageBox.Show("Первая тройка четная"); }
                    if (time2) { MessageBox.Show("Вторая тройка нечетная"); } else { MessageBox.Show("Вторая тройка четная"); }
                }
                else
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1) { MessageBox.Show("Первая тройка нечетная"); } else { MessageBox.Show("Первая тройка четная"); }
                    if (time2) { MessageBox.Show("Вторая тройка нечетная"); } else { MessageBox.Show("Вторая тройка четная"); }
                    if (time3) { MessageBox.Show("Третья тройка нечетная"); } else { MessageBox.Show("Третья тройка четная"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void EqualityButSeconds_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DisableTextBox.IsChecked == true)
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1 > time2)
                    {
                        MessageBox.Show("Секунды > минуты");
                    }
                    else if (time1 < time2)
                    {
                        MessageBox.Show("Секунды < минуты");
                    }
                    if (time1 >= time2)
                    {
                        MessageBox.Show("Секунды >= минуты");
                    }
                    else if (time1 <= time2)
                    {
                        MessageBox.Show("Секунды <= минуты");
                    }
                    if (time1 == time2)
                    {
                        MessageBox.Show("Секунды и минуты равны");
                    }
                    else if (time1 != time2)
                    {
                        MessageBox.Show("Секунды и минуты не равны");
                    }
                }
                else
                {
                    GetTriads((bool)DisableTextBox.IsChecked);
                    if (time1 > time2 & time2 > time3)
                    {
                        MessageBox.Show("Секунды > минуты и минуты > часов");
                    }
                    else if (time1 < time2 & time2 < time3)
                    {
                        MessageBox.Show("Секунды < минуты и минуты < часов");
                    }
                    if (time1 >= time2 & time2 >= time3)
                    {
                        MessageBox.Show("Секунды >= минуты и минуты >= часов");
                    }
                    else if (time1 <= time2 & time2 <= time3)
                    {
                        MessageBox.Show("Секунды <= минуты и минуты <= часов");
                    }
                    if (time1 == time2 & time2 == time3)
                    {
                        MessageBox.Show("Секунды, минуты и часы равны");
                    }
                    else if (time1 != time2 & time2 != time3)
                    {
                        MessageBox.Show("Секунды, минуты и часы не равны");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
