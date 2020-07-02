using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class second : MonoBehaviour
{
    public Button button;
    public string newScene;
    private void Start()
    {
        button.onClick.AddListener(onButtonClick);
    }
    private void onButtonClick()
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(newScene);
    }
}
