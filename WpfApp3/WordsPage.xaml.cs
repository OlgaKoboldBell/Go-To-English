using System.Windows.Controls;

namespace WpfApp3
{
    public partial class WordsPage : Page
    {
        private WordData _wordData;

        public WordsPage(WordData wordData)
        {
            InitializeComponent();
            _wordData = wordData;
            LoadWords();
        }

        private void LoadWords()
        {
            dataGrid.ItemsSource = _wordData.Words;
        }
    }
}