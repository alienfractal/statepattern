using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuFSM : MenuFSM
{
    public MenuFSM fSM;
    private String ACTIONS;
    public GameMenuHandler gmh;

    int IDX_INTRO = 0;
    int IDX_MENU = 1;
    int IDX_NEWGAME = 2;
    int IDX_STATS = 3;
    int IDX_EXIT = 4;

    public GameMenuFSM(GameMenuHandler _gmh)
    {
        this.gmh = _gmh;
    }

    public void Start()
    {
        fSM = this;
        fSM.setState(SimpleMenuState.INTRO);
        fSM.loadIntro();
        ACTIONS = "";
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void hideScreens()
    {
        foreach (GameObject item in gmh.stateGameObjects)
        {
            item.SetActive(false);
        }
    }


    public override void loadExitGame()
    {
        hideScreens();
        gmh.stateGameObjects[IDX_EXIT].SetActive(true);
        Debug.Log("ExitGame");
    }

    public override void loadIntro()
    {
        hideScreens();
        gmh.stateGameObjects[IDX_INTRO].SetActive(true);
        Debug.Log("Intro");
    }

    public override void loadMenu()
    {
        hideScreens();
        gmh.stateGameObjects[IDX_MENU].SetActive(true);
        Debug.Log("Menu");

    }

    public override void loadNewGame()
    {
        hideScreens();
        gmh.stateGameObjects[IDX_NEWGAME].SetActive(true);
        Debug.Log("NewGame");
    }

    public override void loadStats()
    {
        hideScreens();
        gmh.stateGameObjects[IDX_STATS].SetActive(true);
        Debug.Log("Stats");
    }
}