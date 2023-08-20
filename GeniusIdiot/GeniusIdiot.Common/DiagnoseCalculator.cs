using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusIdiot.Common
{
    public class DiagnoseCalculator
    {
        public static string Calculate(int countQuation, int countAnswers)
        {
            var diagnoses = GetDiagnosis();
            var percenRightanswers = countAnswers * 100 / countQuation;
            var percentOfOneAnswers = Math.Round((double)100 / countQuation, 0, MidpointRounding.AwayFromZero);
            return diagnoses[percenRightanswers / (int)percentOfOneAnswers];
        }
        public static List<string> GetDiagnosis()
        {
            var diagnosis = new List<string>();
            diagnosis.Add("Идиот");
            diagnosis.Add("Кретин");
            diagnosis.Add("Дурак");
            diagnosis.Add("Нормальный");
            diagnosis.Add("Талант");
            diagnosis.Add("Гений");
            return diagnosis;
        }
    }
}
