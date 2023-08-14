using System.Text;
using GeniusIdiot.Common;
public class FileProvider
{
    public static void Append(string textFileName, string resultForRecord)   //добавляем значение в файл
    {
        using (var tableResult = new StreamWriter(textFileName, true, System.Text.Encoding.Default))
        {
            tableResult.WriteLine(resultForRecord);
        }
    }
    public static string GetValue(string fileName)
    {
        var reader = new StreamReader(fileName, Encoding.UTF8);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }

    public static bool Exists(string fileName)
    {
        return File.Exists(fileName);
    }

    public static void Clear(string fileName)
    {
        File.WriteAllText(fileName, string.Empty);
    }
}