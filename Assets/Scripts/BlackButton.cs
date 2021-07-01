using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackButton : ButtonControl
{

    private void Start()
    {
        image.color = Color.black;
    }

    public void DestroyAll()
    {
        Shape[] shapes = FindObjectsOfType<Shape>();

        foreach(Shape shape in shapes)
        {
            Destroy(shape.transform.gameObject);
        }
    }

}
