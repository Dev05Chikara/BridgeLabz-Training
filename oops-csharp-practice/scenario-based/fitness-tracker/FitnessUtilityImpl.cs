using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal class FitnessUtilityImpl : ITrackable
    {
        private UserProfile[] users;
        private WorkOut[] userExercises;
        private int userCount;

        public FitnessUtilityImpl(int size)
        {
            users = new UserProfile[size];
            userExercises = new WorkOut[size];
            userCount = 0;
        }

        public void AddUsers()
        {
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Weight: ");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Height: ");
            double Height = Convert.ToDouble(Console.ReadLine());
            
            UserProfile user = new UserProfile(userCount, Name, Age, Weight, Height);
            if (!user.IsValid())
            {
                throw new ArgumentException("User profile has invalid or missing fields", nameof(user));
            }
            if(userCount >= users.Length)
            {
                throw new ArgumentException("Gym is Full");
            }

            users[userCount++] = user;

        }

        public void AddExercise(int id)
        {
            Console.Write("Enter set Of Cardio: ");
            int cardio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter set Of Shoulder Press: ");
            int shoulderPress = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter set Of Leg Press: ");
            int legPress = Convert.ToInt32(Console.ReadLine());
            WorkOut exercise = new WorkOut(cardio, shoulderPress,legPress);
            if(id < 0)
            {
                throw new ArgumentException("Add User first", nameof (userCount));
            }
            else
            {
                userExercises[id] = exercise;
            }
        }

        

        public void reps(int id)
        {
            users[id].ToString();
            userExercises[id].ToString();
        }

        public void ShowExercise(int id)
        {
            Console.WriteLine(userExercises[id].ToString());
        }
    }
}
