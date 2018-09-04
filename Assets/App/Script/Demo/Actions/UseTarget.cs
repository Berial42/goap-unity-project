using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTarget : GoapAction {

    private void Awake()
    {
        preconditions = new Dictionary<string, object>();
        effects = new Dictionary<string, object>();
        preconditions.Add("isNear", true);
        effects.Add("objectUsed", true);
        effects.Add("isHungry", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Run(GoapPlanner planner, GoapAgent agent)
    {
        _parentagent = agent;
        _parentplanner = planner;
        Debug.Log("Use");
        _parentplanner.worldState["objectUsed"] = true;
        Destroy((GameObject)_parentplanner.worldState["objectToUse"]);
        actionState = EActionState.END;
        _parentplanner.ExecuteNextPlanAction();
    }
}
