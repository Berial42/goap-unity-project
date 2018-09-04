using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapAction : MonoBehaviour, IGoapAction {

    public enum EActionState {
        START,
        RUNNING,
        END,
        ERROR
    }
    public GoapPlanner _parentplanner;
    public GoapAgent _parentagent;
    public EActionState actionState;
    public float thisActionCost = 1;
    public Dictionary<string, object> preconditions;
    public Dictionary<string, object> effects;

    #region interface implementation
    public float actionCost
    {
        get
        {
            return thisActionCost;
        }
    }

    public IGoapAgent thisAgent
    {
        get
        {
            return this.gameObject.GetComponent<IGoapAgent>();
        }

        set
        {
            thisAgent = value;
        }
    }

    public IGoapAction nextAction
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
            throw new System.NotImplementedException();
        }
    }


    public Dictionary<string, string> GetEffects()
    {
        throw new System.NotImplementedException();
    }

    public Dictionary<string, string> GetPreconditions()
    {
        throw new System.NotImplementedException();
    }

    public virtual void Run(GoapPlanner planner, GoapAgent agent) {}

    public void Exit() {}
    #endregion
}
