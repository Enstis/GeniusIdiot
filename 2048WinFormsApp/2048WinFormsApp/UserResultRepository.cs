using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    
    public class UserResultRepository
    {
        public static string Path = "2048result.json";

        public static void Save(User user)
        {
            var userResults = GetUserResults();
            userResults.Add(user);
            userResults.Sort(new ScoreComparer());
            SaveFile(userResults);

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
}