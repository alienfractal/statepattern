using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscaFSM : CivFSM
{
    private CivilManager civMan;
    private int d8;
    private int d4;

    private int d12;
    private int d20;

    public int wood;
    public int rock;
    public int salt;
    public int cotton;

    public int corn;

    public int chicha;

    public int meat;

    public int potatoes;
    private float CarryingCapacity;
    private int InitialPopulation;
    private float GrowthRate;

    private PopulationModel popModel;

    public MuiscaFSM(string name, int population, float foodsupply,
    float materialstockpile, float foodProductionRate, float materialProductionRate,
    float foodConsuptionRatePerperson, float materialConsuptionRatePerperson,
    float economicStrength, TechnologicalLevel technologicalLevel, float militaryStrength) : base(name, population, foodsupply, materialstockpile, foodProductionRate, materialProductionRate, foodConsuptionRatePerperson, materialConsuptionRatePerperson, economicStrength, technologicalLevel, militaryStrength)
    {
        
        Name = name;
        Population = population;
        Foodsupply = foodsupply;
        Materialstockpile = materialstockpile;
        FoodProductionRate = foodProductionRate;
        MaterialProductionRate = materialProductionRate;
        FoodConsuptionRatePerperson = foodConsuptionRatePerperson;
        MaterialConsuptionRatePerperson = materialConsuptionRatePerperson;
        EconomicStrength = economicStrength;
        CurrentTechLevel = technologicalLevel;
        MilitaryStrength = militaryStrength;
        updateDiceValues();
        
        CarryingCapacity = 1000;
        InitialPopulation = population;
        GrowthRate = 0.1f;

        popModel = new PopulationModel(InitialPopulation,GrowthRate,CarryingCapacity,0.15);



    }

    private void updateDiceValues()
    {
        d4 = UnityEngine.Random.Range(1, 4);
        d8 = UnityEngine.Random.Range(1, 8);
        d12 = UnityEngine.Random.Range(1, 12);
        d20 = UnityEngine.Random.Range(1, 20);
    }


    // Method to update resource production for a turn/cycle
    public void UpdateResourceProduction()
    {
          Debug.Log("popModel.CarryingCapacity : "+ popModel.CarryingCapacity+" Foodsupply: "+Foodsupply);
        //Food and materials should be handled by bartering
        // float nextFoodsupply = FoodProductionRate - (Population * FoodConsuptionRatePerperson);
        Foodsupply += FoodProductionRate;
        Foodsupply -= Population * FoodConsuptionRatePerperson;
        // Ensure food supply does not go negative
        if (Foodsupply < 0) { Foodsupply = 0; }

        //float nextMaterialstockpile =MaterialProductionRate - (Population * MaterialConsuptionRatePerperson);
        // MAterial gathering will be handled by Bartering. 
        
        Materialstockpile -= Population * MaterialConsuptionRatePerperson;
        Materialstockpile += MaterialProductionRate;
        for (int i = 0; i < MaterialProductionRate; i++)
        {produceFood();
            
        }
       
        // Ensure material stockpile does not go negative
        if (Materialstockpile < 0) {Materialstockpile = 0;}
        if(Foodsupply<=0){
            popModel.CarryingCapacity-=0.25*popModel.CarryingCapacity;
            Debug.Log("popModel.CarryingCapacity : "+ popModel.CarryingCapacity);
        }
        else if(Foodsupply>0 && popModel.CarryingCapacity < 1000.0 ){
             popModel.CarryingCapacity+=0.25*popModel.CarryingCapacity;
        }
    }

    public void produceFood(){
        d4 = UnityEngine.Random.Range((int)Resource.Corn,(int) Resource.Chicha+1);
    
        switch (d4)
        {
            case 0:
                corn+=1;
            break;
            case 1:	    
                meat+=1;
            break;
            case 2:
                potatoes+=1;
            break;
            case 3:
                chicha+=1;
            break;
            
        }
      }

    // Method to update population based on available resources
    public void UpdatePopulation()
    {
        popModel.UpdatePopulation();
        double newPopulation = popModel.CurrentPopulation;
        Population = (int)newPopulation;
    }

    public CivilManager CivMan { get => civMan; set => civMan = value; }


    public override void gameIdle()
    {
        transition(CivInput.Idle);
        enter();
    }

    public override void gameUpdate()
    {
        UpdatePopulation();
        UpdateResourceProduction();
        updateDiceValues();
        transition(CivInput.Update);
        enter();
    }

    public override void gameTrade()
    {
        transition(CivInput.Trade);
        enter();
    }

    public override void gameDefend()
    {
        transition(CivInput.Defend);
        enter();
    }

    public override void updateUI()
    {
        civMan.updateUI();
    }
}
