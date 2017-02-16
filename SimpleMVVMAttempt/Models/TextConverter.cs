using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVMAttempt.Models
{
    public class TextConverter
    {
        private readonly Func<string, string> _convertion;

        public TextConverter(Func<string, string> conversion)
        {
            _convertion = conversion;
        }

        public string ConvertText(string inputText)
        {
            return _convertion(inputText);
        }
    }
}
