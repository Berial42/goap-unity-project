using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapPlanner : MonoBehaviour {

    public List<GoapAction> possibleGoapActions;
    public Dictionary<string, object> possibleGoapGoals;

    GoapGoal currentGoal;
    GoapAction currentAction;
    Queue<GoapAction> currentFSMQueue;
    GoapAgent agent;

    public Dictionary<string, object> worldState;

    bool shouldUpdate = false;

    private void Awake()
    {
        possibleGoapActions = new List<GoapAction>(GetComponents<GoapAction>());
        possibleGoapGoals = new Dictionary<string, object>();
        agent = GetComponent<GoapAgent>();
        worldState = new Dictionary<string, object>();
        worldState.Add("isNear", false);
        worldState.Add("targetPosition", Vector3.zero);
        worldState.Add("objectUsed", false);
        worldState.Add("objectToUse", null);
        worldState.Add("isHungry", true);
        currentFSMQueue = new Queue<GoapAction>();
        possibleGoapGoals.Add("isHungry", true);
        possibleGoapGoals.Add("isIdle", false);
        possibleGoapGoals.Add("hasEnemy", false);
    }

    // Use this for initialization
    void Start () {
        RecalculateActionQueue();
        RunCurrentPlan();
	}

    // Update is called once per frame
    void Update()
    {
    }

    List<GoapGoal> SearchValidGoals()
    {
        return null;
    }

    List<GoapAction> SearchForValidActions() {
        return null;
    }

    void RunCurrentPlan() {
        if (currentFSMQueue.Count > 0)
        {
            currentAction = currentFSMQueue.Dequeue();
            currentAction.Run(this, agent);
        }
        else
        {
            RecalculateActionQueue();
            RunCurrentPlan();
        }
    }
    
    void RecalculateActionQueue() {
        for (int i = 0; i < possibleGoapActions.Count; i++)
        {
            currentFSMQueue.Enqueue(possibleGoapActions[i]);
        }
    }

    public void ExecuteNextPlanAction() {

        RunCurrentPlan();
    }
}
