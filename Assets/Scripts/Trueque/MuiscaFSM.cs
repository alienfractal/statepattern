using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscaFSM : CivFSM
{
    private CivilManager civMan;

   

    public MuiscaFSM( string name, int population, float foodsupply,
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
        Foodsupply += FoodProductionRate - (Population * FoodConsuptionRatePerperson);
        Materialstockpile += MaterialProductionRate - (Population * MaterialConsuptionRatePerperson);
    }

    // Method to update population based on available resources
    public void UpdatePopulation()
    {
        float foodBasedGrowth = Foodsupply >= Population ? 1.02f : 0.98f; // Example growth/decline rates
        float housingBasedGrowth = Materialstockpile >= Population ? 1.01f : 0.99f;

        Population = (int)(Population * foodBasedGrowth * housingBasedGrowth);
    }

     public CivilManager CivMan { get => civMan; set => civMan = value; }

     
    public override void gameIdle()
    {
        transition(CivInput.Idle);
    }

    public override void gameUpdate()
    {
        transition(CivInput.Update);
    }

    public override void gameTrade()
    {
       transition(CivInput.Trade);
    }

    public override void gameDefend()
    {
        transition(CivInput.Defend);
    }

    public override void updateUI()
    {
        
    }
}
