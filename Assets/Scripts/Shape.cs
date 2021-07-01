using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    Material material;
    GameManager manager;

    private void Awake()
    {
        material = GetComponent<Renderer>().material;
        
    }

    
    void OnMouseDown()
    {
        DisplayText();
        ChangeColor();
    }

    protected virtual void DisplayText()
    {
        Debug.Log(gameObject.name);
    }

    protected virtual void ChangeColor()
    {
        manager = FindObjectOfType<GameManager>();
        material.color = manager.SelectedColor;
    }

}
