﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSignManager : MonoBehaviour
{

    public Text WordText, IndexText;
    public GameObject R, SR, SSR;
    public GameObject RSound;

    private NewWordMenu wordData;
    private GameController gameController; //ref
    private AudioSource BGM;

    public void Awake()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    private void OnEnable()
    {
        if(!BGM)
            BGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        BGM.volume = 0.25f;
    }

    private void OnDisable()
    {
        BGM.volume = 1f;
    }

    public void SetWord(NewWordMenu wordData, int index)
    {
        this.wordData = wordData;
        WordText.text = wordData.Word;
        IndexText.text = index.ToString();
    }

    //Used by animation
    public void ShowRarityIcon()
    {
        switch (wordData.Rarity)
        {
            case 1:
                R.SetActive(true);
                break;
            case 2:
                SR.SetActive(true);
                break;
            case 3:
                SSR.SetActive(true);
                break;
        }

        //Set text
        gameController.AddConceptWord(wordData.Word);
    }

    public void PlayOpendSound()
    {
        RSound.SetActive(true);
    }
}
