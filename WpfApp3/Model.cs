using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    
        public class Word
        {
            public int Id { get; set; }
            public string EnglishWord { get; set; }
            // Додайте інші поля, якщо потрібно
        }

        public class Translation
        {
            public int Id { get; set; }
            public int WordId { get; set; }
            public string TranslationText { get; set; }
          
        
    }
}
