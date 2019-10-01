using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateHandler : MonoBehaviour
{


    public GameObject[] stateGameObjects;
    private GamemodelStatemachine gamemodelStatemachine;



    public enum UISateGameObject
    {
        gameFlow_Intro,
        gameFlow_Menu,
        gameFlow_New_Game,
        gameFlow_Stats,
        gameFlow_Final
    }

    // Start is called before the first frame update
    void Start()
    {

        setGamemodelStatemachine(new GamemodelStatemachine(this));
        getGamemodelStatemachine().getSCIGms().setSCIGmsOperationCallback(new GameMenuCallback());
        getGamemodelStatemachine().init();
        getGamemodelStatemachine().enter();


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

    public GamemodelStatemachine getGamemodelStatemachine()
    {
        return gamemodelStatemachine;
    }

    public void setGamemodelStatemachine(GamemodelStatemachine value)
    {
        this.gamemodelStatemachine = value;
    }

    public void enterIntro()
    {
        hideScreens();
        Debug.Log((int)UISateGameObject.gameFlow_Intro);
        stateGameObjects[(int)UISateGameObject.gameFlow_Intro].SetActive(true);

    }
    public void enterMenu()
    {
        hideScreens();
        stateGameObjects[(int)UISateGameObject.gameFlow_Menu].SetActive(true);
    }
    public void enterGame()
    {
        hideScreens();
        stateGameObjects[(int)UISateGameObject.gameFlow_New_Game].SetActive(true);

    }


    public void enterStatsState()
    {
        hideScreens();
        stateGameObjects[(int)UISateGameObject.gameFlow_Stats].SetActive(true);

    }

    public void enterFinalState()
    {
        hideScreens();
        stateGameObjects[(int)UISateGameObject.gameFlow_Stats].SetActive(true);

    }


    public void setNextState(UISateGameObject nextState)
    {
        switch (nextState)
        {
            case UISateGameObject.gameFlow_Intro:
                gamemodelStatemachine.getSCIGms().raiseIntro();
                break;
            case UISateGameObject.gameFlow_Menu:
                gamemodelStatemachine.getSCIGms().raiseMenu();
                break;
            case UISateGameObject.gameFlow_Stats:
                gamemodelStatemachine.getSCIGms().raiseStats();
                break;
            case UISateGameObject.gameFlow_New_Game:
                gamemodelStatemachine.getSCIGms().raiseNewGame();
                break;
            default:
                gamemodelStatemachine.getSCIGms().raiseIntro();
                break;

        }


    }
}
