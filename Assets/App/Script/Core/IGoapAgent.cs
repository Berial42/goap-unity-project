using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public interface IGoapAgent {
    GoapPlanner planner { get; set; }
    NavMeshAgent navAgent { get; set; }

    List<GoapAction> GetPossibleActions();
    Dictionary<string, object> GetPossibleGoals();
    bool IsActive();
}
