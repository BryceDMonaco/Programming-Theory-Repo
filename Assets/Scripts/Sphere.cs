using System;
using System.Collections;
using System.Collections.Generic;

// INHERITANCE
public class Sphere : Shape
{
    public float radius;

    public Sphere(float radius)
    {
        name = "Sphere";
        this.radius = radius;
        CalculateVolume();
    }

    // POLYMORPHISM
    protected sealed override float CalculateVolume()
    {
        volume =(float) ((4.0f / 3.0f) * Math.PI * Math.Pow(radius, 3));

        return volume;
    }
}
