using System.Windows.Controls;
using System.Windows;
using System.Windows.Navigation;

 

namespace WpfApp3

{

    public partial class Task1 : Page

    {

        private MainWindow mainWindow;

        private string[] correctTranslations = { "Яблуко", "Машина", "Книга" };

        private string[] englishWords = { "Apple", "Car", "Book" };

        private int correctCount = 0;



        public Task1()

        {

            InitializeComponent();

            englishLabel1.Content = "English Word: " + englishWords[0];

            englishLabel2.Content = "English Word: " + englishWords[1];

            englishLabel3.Content = "English Word: " + englishWords[2];

            mainWindow = new MainWindow();

        }



        private void CheckTranslations_Click(object sender, RoutedEventArgs e)

        {

            string selectedTranslation1 = GetSelectedTranslation(option1_1, option1_2, option1_3);

            string selectedTranslation2 = GetSelectedTranslation(option2_1, option2_2, option2_3);

            string selectedTranslation3 = GetSelectedTranslation(option3_1, option3_2, option3_3);



            if (selectedTranslation1 == correctTranslations[0])

                correctCount++;

            if (selectedTranslation2 == correctTranslations[1])

                correctCount++;

            if (selectedTranslation3 == correctTranslations[2])

                correctCount++;



            if (correctCount == 3)

            {

                MessageBox.Show("All translations are correct!");

            }

            else

            {

                MessageBox.Show("Some translations are incorrect. Please try again.");

            }



            MessageBox.Show("Your score: " + correctCount + " / 3");

            correctCount = 0; // Reset the count for next attempt

        }



        private string GetSelectedTranslation(params RadioButton[] options)

        {

            foreach (RadioButton option in options)

            {

                if (option.IsChecked == true)

                    return option.Content.ToString();

            }

            return "";

        }

      

        private void To_Menu(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            Window.GetWindow(this).Hide();
        }
    }

}
