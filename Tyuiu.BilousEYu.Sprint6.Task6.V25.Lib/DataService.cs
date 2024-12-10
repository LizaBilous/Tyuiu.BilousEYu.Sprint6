using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BilousEYu.Sprint6.Task6.V25.Lib
{
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string str, string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    else
                    {
                        List<string> result = new List<string>();
                        MatchCollection words = Regex.Matches(line, @"[А-Яа-яA-Za-z]+");
                        foreach (var word in words)
                        {
                            result.Add(word.ToString());
                        }

                        foreach (var word in result)
                        {
                            if (word.Contains("E") || word.Contains("e"))
                            {
                                resStr += word + " ";
                            }
                        }
                    }
                }
            }
            resStr = resStr.Trim();
            return resStr;
        }

        public string CollectTextFromFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
