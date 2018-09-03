using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoapAction : MonoBehaviour, IGoapAction<string, string> {

    public float thisActionCost = 1;

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

    public IGoapAction<string, string> nextAction
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

    public void Exit()
    {
        nextAction.Run();
    }

    public Dictionary<string, string> GetEffects()
    {
        throw new System.NotImplementedException();
    }

    public Dictionary<string, string> GetPreconditions()
    {
        throw new System.NotImplementedException();
    }

    public void Run()
    {
        while (true)
        {
            //run action
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
