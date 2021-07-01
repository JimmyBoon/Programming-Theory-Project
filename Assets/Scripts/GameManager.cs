using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Color chosenColor;
    [SerializeField] string playerName;

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
        if(FindObjectsOfType<GameManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void EnterName(string inputText)
    {
        playerName = inputText;
        Debug.Log(playerName);
        SceneManager.LoadScene(1);
    }

}
