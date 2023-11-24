using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System;


public class GamePanelManager : MonoBehaviour
{
    public GameObject civPanel;
    public GameObject mapPanel;
    public GameObject truequePanel;



    public TMP_Text tMpopulation;
    public TMP_Text tMfoodSupply;
    public TMP_Text tMmaterialStock;
    public TMP_Text tMfoodConsumption;
    public TMP_Text tMmaterialConsmption;



    public String strMpopulation = "Population: ";
    public String strFoodSupply = "FoodSupply: ";
    public String strMaterialStock = "Materials: ";
    public String strFoodConsumption = "FoodUsed: ";
    public String strMaterialConsmption = "Materials used: ";

    public String strBtnTradeFood = "foodBtn";
    public String strBtnTradeMaterials = "materialBtn";
    // Start is called before the first frame update

    public CivilManager civMan;
    void Start()
    {
        Debug.Log("GamePanelManager");
    }

    void OnEnable()
    {
        // This will be called every time the GameObject is activated.
        Debug.Log("GamePanelManager wokeup");
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void updateUI(int population, float foodSupply, float materialStock, float foodConsumption, float materialConsmption)
    {
        this.tMfoodSupply.SetText(strFoodSupply + foodSupply.ToString());
        this.tMpopulation.SetText(strMpopulation + population.ToString());
        this.tMmaterialStock.SetText(strMaterialStock + materialStock.ToString());
        this.tMfoodConsumption.SetText(strFoodConsumption + foodConsumption.ToString());
        this.tMmaterialConsmption.SetText(strMaterialConsmption + materialConsmption.ToString());
    }

    public void clickOnGameObject(GameObject clickedObject)
    {


        
        if(clickedObject.name.Equals(strBtnTradeFood)){
            Debug.Log("Trade food");
            civMan.gameTrade(civMan.muiscaciv,civMan.muiscaciv2,"food");
        }
        else if (clickedObject.name.Equals(strBtnTradeMaterials)){
            Debug.Log("Trade materials");
            civMan.gameTrade(civMan.muiscaciv,civMan.muiscaciv2,"material");
        }


    }

}
