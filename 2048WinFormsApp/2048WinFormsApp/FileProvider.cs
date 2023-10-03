using Newtonsoft.Json;
using System.Text;

namespace _2048WinFormsApp
{
    public class FileProvider
    {

        public static void Append(string fileName, string resultForRecord)   //добавляем значение в файл
        {
            using (var tableResult = new StreamWriter(fileName, false, Encoding.Default))
            {
                tableResult.WriteLine(resultForRecord);
            }
        }
        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

    }
}