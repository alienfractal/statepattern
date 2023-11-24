using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilManager : MonoBehaviour
{
    // Start is called before the first frame update
    public MuiscaFSM muiscaciv;
    public MuiscaFSM muiscaciv2;

    public GamePanelManager gamePanelManager;

    private int randomInt;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init()
    {
        randomInt = UnityEngine.Random.Range(1, 10);
        muiscaciv = new MuiscaFSM("Bacata",
        100, 300.0f, 130.0f, 25.0f, 60.0f, 1, 1, 1, 1, 1);
        muiscaciv.CivMan = this;
        muiscaciv.setState(CivFSM.CIVIDLE);
        gameIdle();
    }


    public void gameDefend()
    {
        Debug.Log(muiscaciv.ACTIONS);
        muiscaciv.gameDefend();
        muiscaciv.gameIdle();
    }

    public void gameIdle()
    {
        Debug.Log("CivilManager gameIdle");
        Debug.Log(muiscaciv.ACTIONS);
        muiscaciv.gameIdle();

    }

    public void gameTrade(CivFSM trader1, CivFSM trader2, String resource)
    {
        if (resource.Equals("food"))
        {
            muiscaciv.Foodsupply += 50;
        }
        else if (resource.Equals("material"))
        {
            muiscaciv.Materialstockpile += 20;
        }


        Debug.Log(muiscaciv.ACTIONS);
        muiscaciv.gameTrade();
        muiscaciv.gameIdle();
    }

    public void gameUpdate()
    {
        Debug.Log(muiscaciv.ACTIONS);
        muiscaciv.gameUpdate();
        muiscaciv.gameIdle();
    }

    public void updateUI()
    {
        //Debug.Log(muiscaciv.ACTIONS);
        gamePanelManager.updateUI(muiscaciv.Population, muiscaciv.Foodsupply, muiscaciv.Materialstockpile, muiscaciv.FoodConsuptionRatePerperson, muiscaciv.MaterialConsuptionRatePerperson);
    }
}
