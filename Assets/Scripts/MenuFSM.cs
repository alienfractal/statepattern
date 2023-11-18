using FSMMenuSys;
public abstract class MenuFSM
{
public enum MenuInput
{
    StartGame,
    ShowIntro,
    ShowStats,
    ExitGame,
    MainMenu
}

  private IMenuState currentState;
  public static GExit GEXIT = new GExit();
  public static GIntro GINTRO = new GIntro();
  public static GStart GSTART = new GStart();
  public static Gstats GSTATS = new Gstats();
  public static GMenu GMENU = new GMenu();
  /**
  *Events
  */
  public void enter()
  {
    currentState?.enter(this);
  }

  public void exit()
  {
    currentState?.exit(this);
  }

  public IMenuState getState()
  {
    return this.currentState;
  }

      // Sets the current state of the FSM
    public void setState(IMenuState newState)
    {
        currentState?.exit(this);
        currentState = newState;
        currentState?.enter(this);
    }
     // Method to handle input
    public void handleInput(MenuInput input)
    {
        currentState?.handleTransition(this, input);
    }
  //All the FSM actions are described below. 
  public abstract void gameStart();
  public abstract void gameIntro();
  public abstract void gameStats();
  public abstract void gameExit();
  public abstract void gameMenu();
}
