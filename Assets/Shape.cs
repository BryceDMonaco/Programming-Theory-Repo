using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;

public abstract class Shape
{
    public float volume { get; protected set; }
    public string name { get; protected set; }

    protected abstract float CalculateVolume();
}
