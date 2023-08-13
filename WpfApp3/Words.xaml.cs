using Microsoft.Win32;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows;
using System;
using WpfApp3;
using System.Linq;


 

 

namespace WpfApp3

{

    public partial class Words : Page

    {

        private MainWindow mainWindow;

        //private Dictionary<string, (Image image, TextBlock text)> wordMap;

        private Dictionary<string, (Image image, TextBlock text)> wordMap;





        public Words()

        {

            InitializeComponent();

            mainWindow = new MainWindow();

            InitializeWordMap();

        }
        private void InitializeWordMap()

        {

            //wordMap = new Dictionary<string, (Image image, TextBlock text)>



            wordMap = new Dictionary<string, (Image image, TextBlock text)>

            {



                  { "dog", (dogImage, dogText) },

 

                //{ "dog", (dogImage, dogText) },

                { "cat", (catImage, catText) },

                { "house", (houseImage, houseText ) },

                { "History", (HistoryImage, HistoryText) },

                { "Physics", (PhysicsImage, PhysicsText) },

                { "Mathematics", (MathematicsImage, MathematicsText) },

                { "School", (SchoolImage, SchoolText) },

                { "Drink", (DrinkImage, DrinkText) },

                { "Lunch", (LunchImage, LunchText ) },

 
            };

        }





        private void Button_Click(object sender, RoutedEventArgs e)

        {

            mainWindow.Show();

            Window.GetWindow(this).Hide();

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

                int count = Math.Min(openFileDialog.FileNames.Length, wordMap.Count);

                for (int i = 0; i < count; i++)

                {

                    string filePath = openFileDialog.FileNames[i];

                    try

                    {

                        var image = new System.Windows.Media.Imaging.BitmapImage(new Uri(filePath));

                        wordMap.ElementAt(i).Value.image.Source = image;

                    }

                    catch (Exception ex)

                    {

                        Console.WriteLine("Error loading image: " + ex.Message);

                    }

                }

            }

        }





        private void OnImageTapped(object sender, System.Windows.Input.MouseButtonEventArgs e)

        {

            if (sender is Image image && image.Tag is string word)

            {

                ToggleVisibility(word);

            }

        }





        private void OnWordTapped(object sender, System.Windows.Input.MouseButtonEventArgs e)

        {

            if (sender is TextBlock textBlock && textBlock.Tag is string word)

            {

                ToggleVisibility(word);

 

            }

        }





        private void ToggleVisibility(string word)

        {

            if (wordMap.TryGetValue(word, out var elements))

            {

                elements.image.Visibility = elements.image.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

                elements.text.Visibility = elements.text.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

            }

        }


    }
}

