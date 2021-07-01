using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackButton : ButtonControl
{
    //Inheritance
    private void Start()
    {
        image.color = Color.black;
    }

    //Interesting that even though the Cube has its own script "Cube" it inheritences from "Shape" and is
    //Destroyed with the other shapes in the code below.
    public void DestroyAll()
    {
        Shape[] shapes = FindObjectsOfType<Shape>();

        foreach(Shape shape in shapes)
        {
            Destroy(shape.transform.gameObject);
        }
    }

}
