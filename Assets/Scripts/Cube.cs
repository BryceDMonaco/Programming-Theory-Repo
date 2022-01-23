using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public Vector3 dimensions;

    public Cube(float x, float y, float z)
    {
        dimensions = new Vector3(x, y, z);
        name = "Cube";
        CalculateVolume();
    }

    protected sealed override float CalculateVolume()
    {
        volume = dimensions.x * dimensions.y * dimensions.z;

        return volume;
    }
}
