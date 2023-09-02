using System.Text;
using GeniusIdiot.Common;
public class FileProvider
{
    public static void Append(string fileName, string resultForRecord)   //добавляем значение в файл
    {
        if (fileName.EndsWith("json"))
        {
            using (var tableResult = new StreamWriter(fileName, false, Encoding.Default))
            {
                tableResult.WriteLine(resultForRecord);
            }
        }
        else
        {
            using (var tableResult = new StreamWriter(fileName, true, Encoding.Default))
            {
                tableResult.WriteLine(resultForRecord);
            }
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

    public static void Clear(string fileName)
    {
        File.WriteAllText(fileName, string.Empty);
    }
}