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
        randomInt = Random.Range(1, 10);
        muiscaciv = new MuiscaFSM("Bacata",
        100, (float)300.0, (float)130.0, (float)80.0, (float)93.0, 1, 1, 1, 1, 1);
        muiscaciv.CivMan = this;
        muiscaciv.setState(CivFSM.CIVIDLE);
        gameIdle();
    }


    public void gameDefend()
    {

    }

    public void gameIdle()
    {
        Debug.Log("CivilManager gameIdle");
        muiscaciv.gameIdle();
        Debug.Log(muiscaciv.ACTIONS);
    }

    public void gameTrade()
    {
        throw new System.NotImplementedException();
    }

    public void gameUpdate()
    {
        muiscaciv.gameUpdate();
    }

    public void updateUI()
    {
        gamePanelManager.updateUI(muiscaciv.Population, muiscaciv.Foodsupply, muiscaciv.Materialstockpile, muiscaciv.FoodConsuptionRatePerperson, muiscaciv.MaterialConsuptionRatePerperson);
    }
}
