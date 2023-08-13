

using System.Windows;

using System.Windows.Controls;



namespace WpfApp3

{

    public partial class Task3 : Page

    {

        private string[] correctTranslations = { "Собака", "Будинок" };
        private string[] englishWords = { "Dog", "House" };
        private int correctCount = 0;



        public Task3()
        {
            InitializeComponent();
            englishLabel1.Content = "English Word: " + englishWords[0];
            englishLabel2.Content = "English Word: " + englishWords[1];
        }



        private void CheckTranslations_Click(object sender, RoutedEventArgs e)
        {
            string selectedTranslation1 = GetSelectedTranslation(option1_1, option1_2, option1_3);
            string selectedTranslation2 = GetSelectedTranslation(option2_1, option2_2, option2_3);



            if (selectedTranslation1 == correctTranslations[0])
                correctCount++;
            if (selectedTranslation2 == correctTranslations[1])
                correctCount++;



            if (correctCount == 2)
            {
                MessageBox.Show("All translations are correct!");
            }
            else
            {
                MessageBox.Show("Some translations are incorrect. Please try again.");
            }



            MessageBox.Show("Your score: " + correctCount + " / 2");
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



        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Task2());
        }
    }

}

