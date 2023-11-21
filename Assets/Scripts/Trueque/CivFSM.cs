

using System;

public abstract class CivFSM
{
    public enum CivInput
    {
        Idle,
        Update,
        Trade,
        Defend

    }


    private ICivState currentState;
    private String name;

    //Basic civ properties
    private int population;
    private float foodsupply;
    private float materialstockpile;
    //Resource production Rates
    private float foodProductionRate;
    private float materialProductionRate;

    //Consuption and needs
    private float foodConsuptionRatePerperson;
    private float materialConsuptionRatePerperson;

    // Economic and Development Indicators
    private float economicStrength;
    private float technologicalLevel;
    // Diplomatic and Military Properties
    private float militaryStrength;

    protected CivFSM(ICivState currentState, string name, int population, float foodsupply, float materialstockpile, float foodProductionRate, float materialProductionRate, float foodConsuptionRatePerperson, float materialConsuptionRatePerperson, float economicStrength, float technologicalLevel, float militaryStrength)
    {
        this.currentState = currentState;
        this.name = name;
        this.population = population;
        this.foodsupply = foodsupply;
        this.materialstockpile = materialstockpile;
        this.foodProductionRate = foodProductionRate;
        MaterialProductionRate = materialProductionRate;
        this.foodConsuptionRatePerperson = foodConsuptionRatePerperson;
        this.materialConsuptionRatePerperson = materialConsuptionRatePerperson;
        this.economicStrength = economicStrength;
        this.technologicalLevel = technologicalLevel;
        this.militaryStrength = militaryStrength;
    }

    public void enter()
    {
        currentState?.enter(this);
    }

    public void exit()
    {
        currentState?.exit(this);
    }

    public ICivState getState()
    {
        return this.currentState;
    }

    // Sets the current state of the FSM
    public void setState(ICivState newState)
    {
        currentState?.exit(this);
        currentState = newState;
        currentState?.enter(this);
    }
    // Method to handle input
    public void handleInput(CivInput input)
    {
        currentState?.handleNextState(this, input);
    }

    public abstract void gameIdle();

    public abstract void gameUpdate();

    public abstract void gameTrade();

    public abstract void gameDefend();

    public abstract void updateUI();


    public string Name { get => name; set => name = value; }
    public int Population { get => population; set => population = value; }
    public float Foodsupply { get => foodsupply; set => foodsupply = value; }
    public float Materialstockpile { get => materialstockpile; set => materialstockpile = value; }
    public float FoodProductionRate { get => foodProductionRate; set => foodProductionRate = value; }
    public float MaterialProductionRate { get => MaterialProductionRate; set => MaterialProductionRate = value; }
    public float FoodConsuptionRatePerperson { get => foodConsuptionRatePerperson; set => foodConsuptionRatePerperson = value; }
    public float MaterialConsuptionRatePerperson { get => materialConsuptionRatePerperson; set => materialConsuptionRatePerperson = value; }
    public float EconomicStrength { get => economicStrength; set => economicStrength = value; }
    public float TechnologicalLevel { get => technologicalLevel; set => technologicalLevel = value; }
    public float MilitaryStrength { get => militaryStrength; set => militaryStrength = value; }


}
