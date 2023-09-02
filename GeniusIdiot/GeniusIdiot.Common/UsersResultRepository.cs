using GeniusIdiot.Common;
using Newtonsoft.Json;

public class UsersResultRepository
{
    public static string Path = "tableResult.json";

    public static void Save(User user)
    {

        var userResults = GetUserResults();
        userResults.Add(user);
        SaveFile(userResults);

        //var resultForRecord = $"{user.Name}*{user.CountRightAnswers}*{user.Diagnose}"; 
        //FileProvider.Append(Path, resultForRecord);

    }

    public static List<User> GetUserResults()
    {
        if (!FileProvider.Exists(Path)) return new List<User>();

        var fileData = FileProvider.GetValue(Path);
        var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
        return userResults;
    }
    static void SaveFile(List<User> userResults)
    {
        var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
        FileProvider.Append(Path, jsonData);
    }
}