using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class VersionText : MonoBehaviour
{
    public string Prefix;
    TextMeshProUGUI versionText;

    
    void Start()
    {
        versionText = GetComponent<TextMeshProUGUI>();
        versionText.text = Prefix + " v " + Application.version;
    }

}
