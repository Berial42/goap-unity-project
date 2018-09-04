using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoapAgent : MonoBehaviour, IGoapAgent {

    public GoapPlanner planner { get; set; }
    public NavMeshAgent navAgent { get; set; }

    public List<GoapAction> GetPossibleActions()
    {
        return planner.possibleGoapActions;
    }

    public Dictionary<string, object> GetPossibleGoals()
    {
        return planner.possibleGoapGoals;
    }

    public bool IsActive()
    {
        return isActiveAndEnabled;
    }
    private void Awake()
    {
        planner = GetComponent<GoapPlanner>();
        navAgent = GetComponent<NavMeshAgent>();
        
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
