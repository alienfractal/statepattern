using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuiscaFSM : CivFSM
{
    public MuiscaFSM(ICivState currentState, string name, int population, float foodsupply,
    float materialstockpile, float foodProductionRate, float materialProductionRate,
     float foodConsuptionRatePerperson, float materialConsuptionRatePerperson,
     float economicStrength, float technologicalLevel, float militaryStrength) : base(currentState, name, population, foodsupply, materialstockpile, foodProductionRate, materialProductionRate, foodConsuptionRatePerperson, materialConsuptionRatePerperson, economicStrength, technologicalLevel, militaryStrength)
    {
        setState(currentState);
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

    // Start is called before the first frame update
    public override void gameDefend()
    {
        throw new System.NotImplementedException();
    }

    public override void gameIdle()
    {
        throw new System.NotImplementedException();
    }

    public override void gameTrade()
    {
        throw new System.NotImplementedException();
    }

    public override void gameUpdate()
    {
        throw new System.NotImplementedException();
    }

     public override void updateUI()
    {
        throw new System.NotImplementedException();
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

   
}
