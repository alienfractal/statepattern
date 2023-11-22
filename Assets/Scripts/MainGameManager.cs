using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameMenuFSM menuFSM;
    public GameObject[] menuItems;
    void Start()
    {
        menuFSM = new GameMenuFSM();
        menuFSM.MgMan = this;
        //Only when the state machine is created
        //Otherwise navigation should go as a transition. 
        menuFSM.setState(MenuFSM.GMENU);
        gameMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //==============================
    public void gameExit()
    {
        menuFSM.gameExit();
        menuItems[4].SetActive(true);
        Debug.Log(menuFSM.ACTIONS);
    }

    public void gameIntro()
    {
        menuFSM.gameIntro();
        menuItems[1].SetActive(true);
        Debug.Log(menuFSM.ACTIONS);
    }

    public void gameMenu()
    {
        menuFSM.gameMenu();
        menuItems[0].SetActive(true);
        Debug.Log(menuFSM.ACTIONS);
    }

    public void gameStart()
    {
        menuFSM.gameStart();
        menuItems[2].SetActive(true);
        Debug.Log(menuFSM.ACTIONS);
    }

    public void gameStats()
    {
        menuFSM.gameStats();
        menuItems[3].SetActive(true);
        Debug.Log(menuFSM.ACTIONS);
        
    }

    public void gameUIClear()
    {
        for (int i = 0; i < menuItems.Length; i++)
        {
            menuItems[i].SetActive(false);
        }
    }

}
