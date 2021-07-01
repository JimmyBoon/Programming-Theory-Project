using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    
    void OnMouseDown()
    {
        DisplayText();
    }

    protected virtual void DisplayText()
    {
        Debug.Log(gameObject.name);
    }

}
