using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static bool select = true;
    public Text ModeText;

    public void SwitchMode()
    {
        select = !select;
        if (select)
            ModeText.text = "select";
        else
            ModeText.text = "disable";
    }
}
