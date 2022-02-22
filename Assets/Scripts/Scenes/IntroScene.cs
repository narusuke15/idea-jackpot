using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    bool waitAnyKey = true;
    public GameObject PressAnyKey, MenuCanvas;
    public GameObject TutorialCanvas;


    // Update is called once per frame
    void Update()
    {
        if (waitAnyKey && Input.anyKeyDown)
        {
            waitAnyKey = false;
            PressAnyKey.SetActive(false);
            MenuCanvas.SetActive(true);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("IGD238");
    }

    public void ShowTutorial()
    {
        TutorialCanvas.SetActive(true);
    }
}
