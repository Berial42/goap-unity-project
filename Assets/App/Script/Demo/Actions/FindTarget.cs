using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTarget : GoapAction {

    private void Awake()
    {
        preconditions = new Dictionary<string, object>();
        effects = new Dictionary<string, object>();
        preconditions.Add("objectToUse", null);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Run(GoapPlanner planner, GoapAgent agent)
    {
        _parentagent = agent;
        _parentplanner = planner;
        InteractableObject io = FindObjectOfType<InteractableObject>();
        if (io != null)
        {
            _parentplanner.worldState["objectToUse"] = io.gameObject;
            _parentplanner.worldState["targetPosition"] = io.gameObject.transform.position;
            Debug.Log("Find" + _parentplanner.worldState["targetPosition"].ToString());
            _parentplanner.ExecuteNextPlanAction();
        }
        else
        {
            //interupt plan
        }
    }
}
