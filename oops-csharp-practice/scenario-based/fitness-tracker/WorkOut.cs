using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal class WorkOut
    {
        // exercise name
        // cardio
        // shoulderPress
        // legPress

        private int Cardio {  get; set; }
        private int ShoulderPress { get; set; }
        private int LegPress { get; set; }

        public WorkOut(int cardio, int shoulderPress, int legPress)
        {
            if (cardio < 0)
            {
                throw new ArgumentException("Cardio must be greater than 0", nameof(cardio));
            }

            if (shoulderPress < 0)
            {
                throw new ArgumentException("Shoulder Press must be greater than 0", nameof(shoulderPress));
            }

            if (legPress < 0)
            {
                throw new ArgumentException("Leg Press must be greater than 0", nameof(legPress));
            }

            Cardio = cardio;
            ShoulderPress = shoulderPress;
            LegPress = legPress;
            
        }

        public override string? ToString()
        {
            return "Cardio: " + Cardio + 
                "\nShoulder Press" + ShoulderPress + 
                "\nLeg Press: " + LegPress;
        }
    }
}
