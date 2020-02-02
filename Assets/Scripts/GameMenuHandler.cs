using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuHandler : MenuFSM
{
    MenuFSM fSM;
    private String ACTIONS;
    public GameObject[] stateGameObjects;


    void Start()
    {
        fSM = this;
        fSM.setState(SimpleMenuState.INTRO);
        ACTIONS = "";
    }

    // Update is called once per frame
    void Update()
    {

    }


      public void hideScreens()
    {
        foreach (GameObject item in stateGameObjects)
        {
            item.SetActive(false);
        }
    }


    public override void loadExitGame()
    {

    }

    public override void loadIntro()
    {
      Debug.Log("LoadingIntro");
    }

    public override void loadMenu()
    {

    }

    public override void loadNewGame()
    {

    }

    public override void loadStats()
    {

    }
}