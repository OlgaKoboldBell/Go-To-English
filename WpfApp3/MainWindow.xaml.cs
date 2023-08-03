﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Image> pictureBoxes;
        public MainWindow()
        {
            InitializeComponent();
            //#if DEBUG
            //            this.AttachDevTools();
            //#endif
            pictureBoxes = new List<Image>();
            pictureBoxes.Add(dogImage);
            pictureBoxes.Add(catImage);
            pictureBoxes.Add(houseImage);
        }

        //вибір теми
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            bt2.Visibility = bt3.Visibility = bt4.Visibility = bt5.Visibility =
            bt6.Visibility = Visibility.Visible;
            bt7.Visibility = bt8.Visibility = bt9.Visibility =
            bt10.Visibility = bt11.Visibility = bt12.Visibility =
            bt13.Visibility = bt14.Visibility = bt15.Visibility = bt16.Visibility =
            bt17.Visibility = tb1.Visibility = tb2.Visibility =
            tb3.Visibility = wb.Visibility = im2.Visibility =
            im3.Visibility = im4.Visibility = im5.Visibility =
            im6.Visibility = sp1.Visibility = Visibility.Hidden;
        }

        //вітання
        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb2.Text = "";
            bt3.Visibility = bt4.Visibility = bt5.Visibility =
                bt6.Visibility = tb2.Visibility = Visibility.Hidden;
            bt7.Visibility = bt8.Visibility = bt9.Visibility = tb1.Visibility =
                wb.Visibility = Visibility.Visible;
            Show_info(".\\texts\\vit.txt");
            //Show_info("D:\\Users\\Olga\\Desktop\\TeamPr\\вітання.txt");

            im2.Visibility = Visibility.Visible;
            wb.Navigate("https://www.facebook.com/107700287287071/posts/185104226213343/");
            //wb.Navigate("https://earn-english.net.ua/dialog/rozmovni-frazi-dlya-dialogiv-zustrich-druziv-privitannya/");
        }


        //тварини
        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb2.Text = "";
            bt2.Visibility = bt4.Visibility = bt5.Visibility =
                bt6.Visibility = tb2.Visibility = Visibility.Hidden;
            bt7.Visibility = bt10.Visibility = bt11.Visibility = tb1.Visibility =
                wb.Visibility = Visibility.Visible;
            Show_info(".\\texts\\anim.txt");
            //Show_info("D:\\Users\\Olga\\Desktop\\TeamPr\\тварини.txt");
            im3.Visibility = Visibility.Visible;
            wb.Navigate("https://www.facebook.com/groups/385095988211813/");

        }

        //їжа
        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb2.Text = "";
            bt3.Visibility = bt2.Visibility = bt5.Visibility =
                bt6.Visibility = tb2.Visibility = Visibility.Hidden;
            bt7.Visibility = bt12.Visibility = bt13.Visibility = tb1.Visibility =
                wb.Visibility = Visibility.Visible;
            //Show_info("texts\\food.txt");
            //Show_info("D:\\Users\\Olga\\Desktop\\TeamPr\\їжа.txt");
            Show_info(".\\texts\\food.txt");
            im4.Visibility = Visibility.Visible;
            wb.Navigate("https://www.facebook.com/watch/?v=2223660781278598");

        }


        //магазин
        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb2.Text = "";
            bt3.Visibility = bt4.Visibility = bt2.Visibility =
                bt6.Visibility = tb2.Visibility = Visibility.Hidden;
            bt7.Visibility = bt14.Visibility = bt15.Visibility = tb1.Visibility =
                wb.Visibility = Visibility.Visible;
            Show_info(".\\texts\\store.txt");
            //Show_info("D:\\Users\\Olga\\Desktop\\TeamPr\\магазин.txt");
            im5.Visibility = Visibility.Visible;
            //wb.Navigate("https://learn-english.net.ua/samovchitel/anglijska-mova-v-magazini-supermarket-i-magazin-odyagu/");

        }


        //погода
        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = tb2.Text = "";
            bt3.Visibility = bt4.Visibility = bt5.Visibility =
                bt2.Visibility = tb2.Visibility = Visibility.Hidden;
            bt7.Visibility = bt16.Visibility = bt17.Visibility = tb1.Visibility =
                wb.Visibility = Visibility.Visible;
            Show_info(".\\texts\\weat.txt");
            //Show_info("D:\\Users\\Olga\\Desktop\\TeamPr\\погода.txt");
            im6.Visibility = Visibility.Visible;
            wb.Navigate("https://www.facebook.com/102084777831742/posts/145375160169370/");
            //wb.Navigate("https://learn-english.net.ua/poradu/pogoda-na-anglijskij-movi-slovnik-po-temi-video-rozpovid/");


        }


        //Вправи
        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb3.Visibility = Visibility.Visible;
            tb3.Text = "Давайте виконаємо вправи - " +
                "виберіть одну із запропонованих";
        }

        //Вправа 1 - вітання
        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\vit_Ex_1.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_1_вітання.txt");
        }

        //Вправа 2 - вітання
        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\vit_Ex_2.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_2_вітання.txt");
        }

        //Вправа 1 - тварини
        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;

            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\anim_Ex_1.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_1_тварини.txt");
        }
        //Вправа 2 - тварини
        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\anim_Ex_2.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_2_тварини.txt");
        }
        //Вправа 1 - їжа
        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\food_Ex_1.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_1_їжа.txt");
        }
        //Вправа 2 - їжа
        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\food_Ex_2.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_2_їжа.txt");
        }
        //Вправа 1 - магазин
        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\store_Ex_1.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_1_магазин.txt");
        }

        //Вправа 2 - магазин
        private void bt15_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\store_Ex_2.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_2_магазин.txt");
        }

        //Вправа 1 - погода
        private void bt16_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\weat_Ex_1.txt");
            //Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_1_погода.txt");
        }

        //Вправа 2 - погода
        private void bt17_Click(object sender, RoutedEventArgs e)
        {
            tb2.Text = "";
            tb2.Visibility = Visibility.Visible;
            wb.Visibility = Visibility.Hidden;
            Show_info2(".\\texts\\weat_Ex_2.txt");
           // Show_info2("D:\\Users\\Olga\\Desktop\\TeamPr\\Вправа_2_погода.txt");
        }

        //На головну
        private void bt18_Click(object sender, RoutedEventArgs e)
        {
            bt2.Visibility = bt3.Visibility = bt4.Visibility = bt5.Visibility =
                bt6.Visibility = bt7.Visibility = bt8.Visibility = bt9.Visibility =
                bt10.Visibility = bt11.Visibility = bt12.Visibility = bt13.Visibility =
                bt14.Visibility = bt15.Visibility = bt16.Visibility = bt17.Visibility =
                wb.Visibility = tb1.Visibility = tb2.Visibility = tb3.Visibility =
                im2.Visibility = im3.Visibility = im4.Visibility = im5.Visibility =
                im6.Visibility = sp1.Visibility = Visibility.Hidden;
        }
        async public void Show_info(string patch)
        {
            try
            {
                using (StreamReader reader = new StreamReader(patch))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        tb1.Text += line;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        async public void Show_info2(string patch)
        {
            try
            {
                using (StreamReader reader = new StreamReader(patch))
                {
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        tb2.Text += line;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        private async void LoadImagesButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Images";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif";

            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                int count = Math.Min(openFileDialog.FileNames.Length, 3);
                for (int i = 0; i < count; i++)
                {
                    string filePath = openFileDialog.FileNames[i];
                    try
                    {
                        var image = new System.Windows.Media.Imaging.BitmapImage(new Uri(filePath));
                        pictureBoxes[i].Source = image;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception if loading the image fails
                        Console.WriteLine("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void OnImageTapped(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (sender is Image image && image.Tag is string word)
            {
                ToggleVisibility(image, word);
            }
        }

        private void OnWordTapped(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (sender is TextBlock textBlock && textBlock.Tag is string word)
            {
                ToggleVisibility(textBlock, word);
            }
        }

        private void ToggleVisibility(Image image, string word)
        {
            if (word == "dog")
            {
                dogImage.Visibility = dogImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                dogText.Visibility = dogText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            else if (word == "cat")
            {
                catImage.Visibility = catImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                catText.Visibility = catText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            else if (word == "house")
            {
                houseImage.Visibility = houseImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                houseText.Visibility = houseText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
        }
        private void ToggleVisibility(TextBlock textBlock, string word)
        {
            if (word == "dog")
            {
                dogImage.Visibility = dogImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                dogText.Visibility = dogText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            else if (word == "cat")
            {
                catImage.Visibility = catImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                catText.Visibility = catText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
            else if (word == "house")
            {
                houseImage.Visibility = houseImage.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                houseText.Visibility = houseText.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        //слова
        private void bt19_Click(object sender, RoutedEventArgs e)
        {
            //this.Background = new SolidColorBrush(Colors.Blue);
            wb.Visibility = bt2.Visibility = bt3.Visibility = bt4.Visibility = bt5.Visibility =
           bt6.Visibility = bt7.Visibility = bt8.Visibility = bt9.Visibility =
            bt10.Visibility = bt11.Visibility = bt12.Visibility =
            bt13.Visibility = bt14.Visibility = bt15.Visibility = bt16.Visibility =
            bt17.Visibility = tb1.Visibility = tb2.Visibility =
            tb3.Visibility = wb.Visibility = im2.Visibility =
            im3.Visibility = im4.Visibility = im5.Visibility =
            im6.Visibility = sp1.Visibility = Visibility.Hidden;
            tb2.Text = "";
            tb2.Visibility = sp1.Visibility = Visibility.Visible;
        }
    }
}
