using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayShape : MonoBehaviour
{
    public enum ShapeType
    {
        Sphere,
        Cube
    }

    public ShapeType thisType;
    public TextMeshProUGUI volumeText;
    public TextMeshProUGUI nameText;
    private Shape myShape;
    
    // Start is called before the first frame update
    void Start()
    {
        if (thisType == ShapeType.Cube)
        {
            // POLYMORPHISM
            myShape = new Cube(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        } else if (thisType == ShapeType.Sphere)
        {
            // This assumes that the sphere is uniformly scaled
            myShape = new Sphere(transform.localScale.x / 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        volumeText.text = "Volume = " + myShape.volume;
        nameText.text = "This shape is a " + myShape.name;
    }
}
