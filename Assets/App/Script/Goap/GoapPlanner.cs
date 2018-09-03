using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapPlanner : MonoBehaviour {

    public List<GoapAction> possibleGoapActions;
    public List<GoapGoal> possibleGoapGoals;

    GoapGoal currentGoal;
    Queue<GoapAction> currentFSMQueue;

    Dictionary<string, string> worldState;

    bool shouldUpdate = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    List<GoapGoal> SearchValidGoals()
    {
        return null;
    }

    List<GoapAction> SearchForValidActions() {
        return null;
    }

    void RunCurrentTree() {

    }
    
    void RecalculateActionQueue() {

    }
}
