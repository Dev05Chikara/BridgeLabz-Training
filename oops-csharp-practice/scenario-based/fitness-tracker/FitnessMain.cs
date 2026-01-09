using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal class FitnessMain
    {
        public static void Main(string[] args)
        {
        FitnessUtilityImpl utility = new FitnessUtilityImpl(10);
        FitnessMenu menu = new FitnessMenu(utility);

        menu.ShowMenu();
                }
}
}
