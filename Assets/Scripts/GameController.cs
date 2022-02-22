using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static bool select = true;
    public Text ModeText;
    public Text ConceptText;
    public Text RarityText;
    public Transform Content;

    public List<WordData> Words;
    public GameObject SignPrefabs;

    public void Start()
    {
        int index = 1;
        int r = 0;
        int sr = 0;
        int ssr = 0;
        foreach (var word in Words)
        {
            var sign = Instantiate(SignPrefabs, Vector3.zero, Quaternion.identity).GetComponent<Sign>();
            sign.WordData = word;
            sign.SetIndex(index);
            sign.transform.SetParent(Content);
            sign.transform.localScale = Vector3.one;
            if (word.Rarity == 1)
                r++;
            else if (word.Rarity == 2)
                sr++;
            else
                ssr++;
            index++;
        }
        RarityText.text = string.Format("R {0}, SR {1}, SSR {2}", r, sr, ssr);
    }

    public void SwitchMode()
    {
        select = !select;
        if (select)
            ModeText.text = "select";
        else
            ModeText.text = "disable";
    }

    public void AddConceptWord(string word)
    {
        ConceptText.text += word + ", ";
    }
}
