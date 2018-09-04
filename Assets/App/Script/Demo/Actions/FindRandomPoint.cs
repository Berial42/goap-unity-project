using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRandomPoint : GoapAction {

    private void Awake()
    {
        preconditions = new Dictionary<string, object>();
        effects = new Dictionary<string, object>();
        preconditions.Add("targetPosition", Vector3.zero);
        effects.Add("targetPosition", Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Run(GoapPlanner planner, GoapAgent agent)
    {
        _parentagent = agent;
        _parentplanner = planner;
        _parentplanner.worldState["targetPosition"] = new Vector3(Random.Range(0f,100f),0, Random.Range(0f, 100f));
        _parentplanner.ExecuteNextPlanAction();    
    }
}
