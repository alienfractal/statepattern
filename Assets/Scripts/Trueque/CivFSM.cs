

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

    public enum Resource { Corn, Meat, Potatoes, Chicha,Wood, Cotton, Rock, Salt}
    //Zipazgo o Zacazgo: Territorio mayor, gobernado por el Zipa o el Zaque
    //Zybyn: Territorio intermedio, gobernado por el Zibyntyba
    //Uta: Territorio menor, o poblado, gobernado por el Utatiba
    public enum TechnologicalLevel{UTA,ZYBYN,ZIPAZGO}

    private TechnologicalLevel currentTechLevel;
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
    
    // Diplomatic and Military Properties
    private float militaryStrength;

     private int deaths;

    public static CivIdle CIVIDLE = new CivIdle();
    public static CivTrade CIVTRADE = new CivTrade();
    public static CivUpdate CIVUPDATE = new CivUpdate();
    public static CivDefend CIVDEFEND = new CivDefend();

    public String ACTIONS;


    public abstract void gameIdle();

    public abstract void gameUpdate();

    public abstract void gameTrade();

    public abstract void gameDefend();

    public abstract void updateUI();
 

    protected CivFSM(string name, int population, float foodsupply, float materialstockpile, float foodProductionRate, float materialProductionRate, float foodConsuptionRatePerperson, float materialConsuptionRatePerperson, float economicStrength, TechnologicalLevel _currentTechLevel, float militaryStrength)
    {
        this.name = name;
        this.population = population;
        this.foodsupply = foodsupply;
        this.materialstockpile = materialstockpile;
        this.foodProductionRate = foodProductionRate;
        this.materialProductionRate = materialProductionRate;
        this.foodConsuptionRatePerperson = foodConsuptionRatePerperson;
        this.materialConsuptionRatePerperson = materialConsuptionRatePerperson;
        this.economicStrength = economicStrength;
        this.currentTechLevel = _currentTechLevel;
        this.militaryStrength = militaryStrength;
    }

    public void enter()
    {
        currentState?.enter(this);
    }

    public void transition(CivInput stateInput)
    {
        currentState?.transition(this,stateInput);
    }

    public ICivState getState()
    {
        return  currentState;
    }

    // Sets the current state of the FSM
    public void setState(ICivState newState)
    {
        currentState = newState;
    }

  


    public string Name { get => name; set => name = value; }
    public int Population { get => population; set => population = value; }
    public float Foodsupply { get => foodsupply; set => foodsupply = value; }
    public float Materialstockpile { get => materialstockpile; set => materialstockpile = value; }
    public float FoodProductionRate { get => foodProductionRate; set => foodProductionRate = value; }
    public float MaterialProductionRate { get => materialProductionRate; set => materialProductionRate = value; }
    public float FoodConsuptionRatePerperson { get => foodConsuptionRatePerperson; set => foodConsuptionRatePerperson = value; }
    public float MaterialConsuptionRatePerperson { get => materialConsuptionRatePerperson; set => materialConsuptionRatePerperson = value; }
    public float EconomicStrength { get => economicStrength; set => economicStrength = value; }
    
    public float MilitaryStrength { get => militaryStrength; set => militaryStrength = value; }
    public int Deaths { get => deaths; set => deaths = value; }
    public TechnologicalLevel CurrentTechLevel { get => currentTechLevel; set => currentTechLevel = value; }
}
