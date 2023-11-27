using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Data
{
    internal class StaticData
    {
        public static string[] alphabet { get; set; } = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static readonly Dictionary<char, double> EnglishLetterFrequencies = new Dictionary<char, double>
        {
            {'a', 0.0815},
            {'b', 0.0144},
            {'c', 0.0276},
            {'d', 0.0379},
            {'e', 0.1311},
            {'f', 0.0292},
            {'g', 0.0199},
            {'h', 0.0526},
            {'i', 0.0635},
            {'j', 0.0013},
            {'k', 0.0042},
            {'l', 0.0339},
            {'m', 0.0254},
            {'n', 0.0710},
            {'o', 0.0800},
            {'p', 0.0198},
            {'q', 0.0012},
            {'r', 0.0683},
            {'s', 0.0610},
            {'t', 0.1047},
            {'u', 0.0246},
            {'v', 0.0092},
            {'w', 0.0154},
            {'x', 0.0017},
            {'y', 0.0198},
            {'z', 0.0008}
        };
    }
}
