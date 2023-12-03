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

    public static int currentCycle;



   

    //For each cycle only one action can be performed, you can only trade once per cycle.
    //Other tasks like arrange food rates, and work distribution can be performed. 
    public bool tradePerformed;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void init()
    {
        tradePerformed = false;
        randomInt = UnityEngine.Random.Range(1, 10);

        muiscaciv = new MuiscaFSM(name: "Bacata",
        population: 100, foodsupply: 300.0f, 
        materialstockpile: 130.0f, foodProductionRate: 25.0f, 
        materialProductionRate: 60.0f, foodConsuptionRatePerperson: 1,
        materialConsuptionRatePerperson: 0.75f, economicStrength: 1, 
        technologicalLevel: CivFSM.TechnologicalLevel.UTA, militaryStrength: 1);

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

    public void gameTrade(CivFSM trader1, CivFSM trader2, CivFSM.Resource resource)
    {
        if (!tradePerformed)
        {
            if (resource.Equals(CivFSM.Resource.Corn))
            {
                muiscaciv.Foodsupply += 50;
                tradePerformed=true;
            }
            else if (resource.Equals(CivFSM.Resource.Wood))
            {
                muiscaciv.Materialstockpile += 20;
                tradePerformed=true;
            }
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
        tradePerformed=false;
        currentCycle+=1;
        Debug.Log("muiscaciv.corn "+muiscaciv.corn+" muiscaciv.meat "+muiscaciv.meat+" muiscaciv.potatoes "+muiscaciv.chicha+" muiscaciv.chicha "+muiscaciv.chicha);
    }

    public void updateUI()
    {
        //Debug.Log(muiscaciv.ACTIONS);
        gamePanelManager.updateUI(muiscaciv.Population, muiscaciv.Foodsupply, muiscaciv.Materialstockpile, muiscaciv.FoodConsuptionRatePerperson, muiscaciv.MaterialConsuptionRatePerperson);
    }
}
