using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeworkRegex
{
    class Program
    {
        //private const string Pattern = @"(\w*e*w\)";
        static void Main(string[] args)
        {
            string text = "Не выходи из комнаты, не совершай ошибку.\n" +
                "Зачем тебе Солнце, если ты куришь Шипку?\n" +
                "За дверью бессмысленно все, особенно - возглас счастья.\n" +
                "Только в уборную - и сразу же возвращайся.\n" +

                "Не выходи из комнаты, не вызывай мотора.\n" +
                "Потому что пространство сделано из коридора\n" +
                "и кончается счетчиком.А если войдет живая\n" +
                "милка, пасть разевая, выгони не раздевая.\n";
            Console.WriteLine(text);
            Regex regex = new Regex(@"(\w*е\w*|\w*а\b)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine("Слово содержит букву 'e' или в конце 'a'= " + match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }




        }
    }
}
