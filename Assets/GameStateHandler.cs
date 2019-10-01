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
        hideScreens();
        setGamemodelStatemachine(new GamemodelStatemachine());
        getGamemodelStatemachine().getSCIGms().setSCIGmsOperationCallback(new GameMenuCallback());
        getGamemodelStatemachine().init();
        getGamemodelStatemachine().enter();
        hideScreens();
        valideGameState();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void valideGameState()
    {

        stateGameObjects[(int)(getGamemodelStatemachine().getCurrentState())].SetActive(true);
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

    public void enterIntro() {

     }
    public void enterMenu() {

     }
    public void enterGame() {

     }
    public void enterFinalState() {

     }

     public void enterStatsState() {

     }
}
