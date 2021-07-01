using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    protected Image image;
    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>();
        
    }

    public void SetSelectedColor()
    {
        Color imageColor = image.color;
        GameManager manager = FindObjectOfType<GameManager>();
        manager.SelectedColor = imageColor;
    }
}
