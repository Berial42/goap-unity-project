using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGoapGoal{

    Dictionary<string, string> GetGoalPrerequisites();
    bool Run();	
}
