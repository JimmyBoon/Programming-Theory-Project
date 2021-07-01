using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Color chosenColor;
    [SerializeField] string playerName;

    //Encapsulation
    public Color SelectedColor
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

    private void Awake()
    {
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    //Encapsulation with error checking
    public string PlayerName
    {
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                playerName = value;
                SceneManager.LoadScene(1);
            }
            else
            {
                Debug.Log("Enter name");
            }

        }
        get
        {
            return playerName;
        }
    }

}
