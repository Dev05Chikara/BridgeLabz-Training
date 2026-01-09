using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased.fitness_tracker
{
    internal interface ITrackable
    {
        void AddUsers();

        void AddExercise(int id);

        void reps(int id);

        void ShowExercise(int id);
    }
}
