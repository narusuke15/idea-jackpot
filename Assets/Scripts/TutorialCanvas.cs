using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvas : MonoBehaviour
{
    public int count = 0;
    public List<GameObject> TutorialList;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject tutorial in TutorialList)
        {
            tutorial.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (count < TutorialList.Count)
            {
                TutorialList[count].SetActive(true);
                count++;
            }
        }
    }
}
