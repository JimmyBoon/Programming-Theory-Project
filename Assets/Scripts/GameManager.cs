using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Color chosenColor;

    [SerializeField] public Color SelectedColor
    {
        get { return chosenColor; }
        set
        {
            if (value != Color.black)
            {
                chosenColor = value;
            }
            else
            {
                Debug.Log("What happened???");
            }
        }

    }


}
