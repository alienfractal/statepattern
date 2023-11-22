
using System;
using FSMMenuSys;
using UnityEngine;
 
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

  public String ACTIONS;
  /**
  *Events
  */
  public void enter()
  {
    //currentState?.enter(this);
      if(currentState != null){
      currentState.enter(this);
    }
    else{
      Debug.Log("State is null");
    }
  }

  public void transition(MenuFSM.MenuInput newState)
  {
    if(currentState != null){
      currentState.transition(this,newState);
    }
    else{
      Debug.Log("State is null");
    }
    
  }

  public IMenuState getState()
  {
    return this.currentState;
  }

  // Sets the current state of the FSM
  public void setState(IMenuState newState)
  {
    currentState = newState;
  }

  //All the FSM actions are described below. 
  public abstract void gameStart();
  public abstract void gameIntro();
  public abstract void gameStats();
  public abstract void gameExit();
  public abstract void gameMenu();
  public abstract void gameUIClear();
}
