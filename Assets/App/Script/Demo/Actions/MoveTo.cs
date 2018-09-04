using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTo : GoapAction {
    public Vector3 vec;
    private void Awake()
    {
        preconditions = new Dictionary<string, object>();
        effects = new Dictionary<string, object>();
        preconditions.Add("targetPosition", Vector3.zero);
        preconditions.Add("isNear", false);
        effects.Add("isNear", true);
    }

    // Update is called once per frame
    void Update () {
        if (actionState == EActionState.RUNNING)
        {
            if (_parentagent.navAgent.remainingDistance <= 0.2f)
            {
                actionState = EActionState.END;
                _parentplanner.worldState["isNear"] = true;
                _parentplanner.ExecuteNextPlanAction();
            }
        }
    }

    public override void Run(GoapPlanner planner, GoapAgent agent) {
        _parentagent = agent;
        _parentplanner = planner;
        float random_1 = Random.Range(0.0f, 100.0f);
        float random_2 = Random.Range(0.0f, 100.0f);
        actionState = EActionState.RUNNING;
        Debug.Log("Move"+ (Vector3)_parentplanner.worldState["targetPosition"]);
        vec = (Vector3)_parentplanner.worldState["targetPosition"];
        agent.navAgent.destination = vec;
        Debug.Log(agent.navAgent.destination);
    }
}
