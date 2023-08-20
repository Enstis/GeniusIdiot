using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParseToNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = int.Parse(input);
                errorMessage = string.Empty;
                return true;
            }
            catch (FormatException)
            {
                errorMessage = "Введите число!";
                number = 0;
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = "Вы ввели слишком большое число!";
                number = 0;
                return false;
            }
        }
    }
}
