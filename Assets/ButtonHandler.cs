using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    //public GameMenuHandler gameMenuHandler;
    public enum UISateGameObject
    {
        gameFlow_Intro,
        gameFlow_Menu,
        gameFlow_New_Game,
        gameFlow_Stats,
        gameFlow_Final
    }

    public UISateGameObject nextState;



    // Start is called before the first frame update
    void Start()
    {
    //    gameMenuHandler = FindObjectOfType<GameMenuHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setNextState()
    {
        Debug.Log(nextState.ToString());
        switch (nextState)
        {
            case UISateGameObject.gameFlow_Intro:
              //  gameMenuHandler.menuFSM.intro();
                break;
            case UISateGameObject.gameFlow_Menu:
              //  gameMenuHandler.menuFSM.menu();
                break;
            case UISateGameObject.gameFlow_New_Game:
              //  gameMenuHandler.menuFSM.newgame();
                break;
            case UISateGameObject.gameFlow_Stats:
               // gameMenuHandler.menuFSM.stats();
                break;
            case UISateGameObject.gameFlow_Final:
                //gameMenuHandler.menuFSM.exitgame();
                break;



        }

    }
}
