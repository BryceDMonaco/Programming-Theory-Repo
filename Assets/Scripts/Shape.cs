using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;

// ABSTRACTION
public abstract class Shape
{
    public float volume { get; protected set; }
    
    // ENCAPSULATION
    public string name { get; protected set; }

    protected abstract float CalculateVolume();
}
