using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
   public interface IGoalService
    {
        void GetAllGoals();
        void GetGoalById(int id);
        void AddNewGoal();
        void UpdateGoal();
        void RemoveGoal(int id);
        void GetGoalByName(string name);
    }
}
