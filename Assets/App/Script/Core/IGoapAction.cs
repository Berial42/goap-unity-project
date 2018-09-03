using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGoapAction<T,W>{

    float actionCost { get; }
    IGoapAgent thisAgent { get; set; }
    IGoapAction<string, string> nextAction { get; set; }

    Dictionary<T, W> GetPreconditions();
    Dictionary<T, W> GetEffects();

    void Run();
    void Exit();
}
