using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGoapAction{

    float actionCost { get; }
    IGoapAgent thisAgent { get; set; }
    IGoapAction nextAction { get; set; }

    Dictionary<string, string> GetPreconditions();
    Dictionary<string, string> GetEffects();

    void Run(GoapPlanner planner, GoapAgent agent);
    void Exit();
}
