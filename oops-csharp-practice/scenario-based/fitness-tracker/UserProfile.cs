using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal class UserProfile
    {

        // id
        // name
        // age
        // weight
        // height

        public int UserId { get; set; }
        private string UserName { get; set; }
        private int UserAge { get; set; }
        private double UserWeight { get; set; }
        private double UserHeight { get; set; }


        public UserProfile(int userId, string userName, int userAge, double userWeight, double userHeight)
        {
            if (userId < 0)
            {
                throw new ArgumentException("UserId must be greater than 0", nameof(userId));
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException("UserName cannot be empty", nameof(userName));
            }

            if (userAge <= 0)
            {
                throw new ArgumentException("UserAge must be greater than 0", nameof(userAge));
            }

            if (userWeight <= 0)
            {
                throw new ArgumentException("UserWeight must be greater than 0", nameof(userWeight));
            }

            if (userHeight <= 0)
            {
                throw new ArgumentException("UserHeight must be greater than 0", nameof(userHeight));
            }

            UserId = userId;
            UserName = userName;
            UserAge = userAge;
            UserWeight = userWeight;
            UserHeight = userHeight;
        }

        public bool IsValid()
        {
            return UserId >= 0 &&
                   !string.IsNullOrWhiteSpace(UserName) &&
                   UserAge > 0 &&
                   UserWeight > 0 &&
                   UserHeight > 0;
        }

        public override string? ToString()
        {
            return "Name: " + UserName +
                "\nAge: " + UserAge +
                "\nWeight: " + UserWeight +
                "\nHeight: " + UserHeight;
        }
    }
}
