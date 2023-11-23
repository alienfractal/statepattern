using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscaFSM : CivFSM
{
    private CivilManager civMan;



    public MuiscaFSM(string name, int population, float foodsupply,
    float materialstockpile, float foodProductionRate, float materialProductionRate,
    float foodConsuptionRatePerperson, float materialConsuptionRatePerperson,
    float economicStrength, float technologicalLevel, float militaryStrength) : base(name, population, foodsupply, materialstockpile, foodProductionRate, materialProductionRate, foodConsuptionRatePerperson, materialConsuptionRatePerperson, economicStrength, technologicalLevel, militaryStrength)
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
        TechnologicalLevel = technologicalLevel;
        MilitaryStrength = militaryStrength;

    }


    // Method to update resource production for a turn/cycle
    public void UpdateResourceProduction()
    {
        //Food and materials should be handled by bartering
       // float nextFoodsupply = FoodProductionRate - (Population * FoodConsuptionRatePerperson);
       Foodsupply -= Population * FoodConsuptionRatePerperson;
          // Ensure food supply does not go negative
        if (Foodsupply < 0) { Foodsupply = 0; }
        
        //float nextMaterialstockpile =MaterialProductionRate - (Population * MaterialConsuptionRatePerperson);
            // MAterial gathering will be handled by Bartering. 
            Materialstockpile -=Population * MaterialConsuptionRatePerperson;
        // Ensure material stockpile does not go negative
        if (Materialstockpile < 0) Materialstockpile = 0;
    }

    // Method to update population based on available resources
    public void UpdatePopulation()
    {

        float foodBasedGrowth = Foodsupply >= Population ? 1.02f : 0.98f; // Example growth/decline rates
        float housingBasedGrowth = Materialstockpile >= Population ? 1.01f : 0.99f;

        Population = (int)(Population * foodBasedGrowth * housingBasedGrowth);
        if (Population < 0) Population = 0;
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