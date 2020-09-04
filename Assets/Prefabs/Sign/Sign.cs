using UnityEngine;
using UnityEngine.UI;

public class Sign : MonoBehaviour
{

    public GameObject OpenSignPrefabs;
    public AudioSource SelectSound;
    public NewWordMenu WordData;
    public int Index;

    public void ShowWord()
    {
        if (GameController.select)
        {
            var openSign = Instantiate( OpenSignPrefabs, Vector3.zero, Quaternion.identity).gameObject;
            openSign.GetComponent<OpenSignManager>().SetWord(WordData, Index);
            SelectSound.Play();
        }

        GetComponent<Button>().enabled = false;
    }

    public void SetIndex(int index)
    {
        Index = index;
        transform.Find("Text").GetComponent<Text>().text = "" + index;
    }
}
