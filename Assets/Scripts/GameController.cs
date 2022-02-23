using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    const string RColor = "#A66C36";
    const string SRColor = "#E9E9E9";
    const string SSRColor = "#FFC500";

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
        //string colorCode;
        foreach (var word in Words)
        {
            var sign = Instantiate(SignPrefabs, Vector3.zero, Quaternion.identity).GetComponent<Sign>();
            sign.WordData = word;
            sign.SetIndex(index);
            sign.transform.SetParent(Content);
            sign.transform.localScale = Vector3.one;
            if (word.Rarity == 1)
            {
                r++;
                //colorCode = RColor;
            }
            else if (word.Rarity == 2)
            {
                sr++;
                ///colorCode = SRColor;
            }
            else
            {
                ssr++;
                //colorCode = SSRColor;
            }
            index++;
        }
        RarityText.text = string.Format("<color=#A66C36>R {0} </color>, <color=#E9E9E9> SR {1} </color>, <color=#FFC500> SSR {2} </color>", r, sr, ssr);
    }

    public void SwitchMode()
    {
        select = !select;
        if (select)
            ModeText.text = "select";
        else
            ModeText.text = "disable";
    }

    public void AddConceptWord(WordData wordData)
    {
        string color;
        if(wordData.Rarity == 1){
            color = RColor;
        }
        else if(wordData.Rarity == 2){
            color = SRColor;
        }
        else{
            color = SSRColor;
        }
        ConceptText.text += "<color=" + color + ">" + wordData.Word + "</color>" + ", ";
    }
}
