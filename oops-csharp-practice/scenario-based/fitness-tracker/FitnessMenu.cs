using BridgeLabzTraining.senariobased.smart_home_automation_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal class FitnessMenu
    {
        private FitnessUtilityImpl utility;

        public FitnessMenu(FitnessUtilityImpl utility)
        {
            this.utility = utility;
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("--------Fitness Menu------");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Add Exercise");
                Console.WriteLine("3. Show Exercise");
                Console.WriteLine("4. Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddUsers();
                        break;

                    case 2:
                        Console.WriteLine("Enter your Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        AddExercise(id);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        ShowExercise(id);
                        break;

                }
            } while (choice != 3);
        }

        private void AddUsers()
        {
            utility.AddUsers();
        }
        private void AddExercise(int id)
        {
            utility.AddExercise(id);
        }
        private void ShowExercise(int id)
        {
            utility.ShowExercise(id);
        }
    }
}
