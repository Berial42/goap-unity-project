using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGoapGoal<T, W>{

    Dictionary<T, W> GetGoalPrerequisites();
    bool Run();	
}
