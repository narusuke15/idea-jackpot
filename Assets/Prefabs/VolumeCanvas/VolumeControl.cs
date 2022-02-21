using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioListener AudioListener;
    public GameObject VolumePanel;
    public Image VolumeValue;

    public static float Volume = 0.5f;
    public float AdjustVolume = 0.1f;
    GameObject volumeControlObject;

    Coroutine ShowVolumeRoutine;

    private void Start()
    {
        AudioListener.volume = Volume;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetVolume(Volume + AdjustVolume);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetVolume(Volume - AdjustVolume);
        }
    }

    public void SetVolume(float volume)
    {
        Volume = Mathf.Clamp01(volume);
        AudioListener.volume = volume;
        if(ShowVolumeRoutine != null)
            StopCoroutine(ShowVolumeRoutine);
        ShowVolumeRoutine = StartCoroutine(ShowVolumeControl());
        VolumeValue.rectTransform.localScale = new Vector3(volume, 1, 1);
    }

    public IEnumerator ShowVolumeControl()
    {
        Debug.Log("SHOW");
        VolumePanel.SetActive(true);
        yield return new WaitForSeconds(1f);
        VolumePanel.SetActive(false);
        Debug.Log("HIDE");
    }

}
