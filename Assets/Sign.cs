using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{

    public string word;

    public void ShowWord()
    {
        if (GameController.select)
        {
            transform.Find("Text").GetComponent<Text>().text = word;
            transform.Find("Text").GetComponent<Text>().color = Color.black;
            GameObject.Find("ConceptText").GetComponent<Text>().text += word + " ";
        }

        GetComponent<Button>().enabled = false;
    }
}
