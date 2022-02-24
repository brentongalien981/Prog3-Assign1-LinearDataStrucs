using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1_Question3_Practice
{
    internal class Athlete
    {
        public string Name { get; }
        public int OlympicYear { get; }
        public int NumOfGold { get; }
        public int NumOfSilver { get; }
        public int NumOfBronze { get; }



        public Athlete(string name, int olympicYear, int numOfGold, int numOfSilver, int numOfBronze)
        {
            Name = name;
            OlympicYear = olympicYear;
            NumOfGold = numOfGold;
            NumOfSilver = numOfSilver;
            NumOfBronze = numOfBronze;
        }
    }
}
