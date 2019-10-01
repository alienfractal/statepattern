using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GamemodelStatemachine : StateFlow
{

    private State[] stateVector = new State[1];
    protected SCIGmsImpl sCIGms;

    private GameStateHandler gameStateHandler;

    private bool initialized = false;
    /**
    * The enum index should match GameObjec array 
*/
    public enum State
    {
        gameFlow_Intro,
        gameFlow_Menu,
        gameFlow__final_,
        gameFlow_New_Game,
        gameFlow_Stats,
        gameFlow_null
    };

    private int nextStateIndex;

    public GamemodelStatemachine(GameStateHandler _gameStateHandler)
    {
        this.gameStateHandler = _gameStateHandler;
        sCIGms = new SCIGmsImpl(this);
    }
    public class SCIGmsImpl : SCIGms
    {
        GamemodelStatemachine gamemodelStatemachine;
        public SCIGmsImpl(GamemodelStatemachine _gamemodelStatemachine)
        {
            this.gamemodelStatemachine = _gamemodelStatemachine;
        }
        public GameMenuCallback operationCallback;

        public void setSCIGmsOperationCallback(SCIGmsOperationCallback operationCallback)
        {
            this.operationCallback = (GameMenuCallback)operationCallback;
        }
        public bool menu;


        public void raiseMenu()
        {
            menu = true;
            gamemodelStatemachine.runCycle();
        }

        public bool finish;


        public void raiseFinish()
        {
            finish = true;
            gamemodelStatemachine.runCycle();
        }

        public bool newGame;


        public void raiseNewGame()
        {
            newGame = true;
            gamemodelStatemachine.runCycle();
        }

        public bool stats;


        public void raiseStats()
        {
            stats = true;
            gamemodelStatemachine.runCycle();
        }

        public bool exitGame;


        public void raiseExitGame()
        {
            exitGame = true;
            gamemodelStatemachine.runCycle();
        }

        public bool intro;


        public void raiseIntro()
        {
            intro = true;
            gamemodelStatemachine.runCycle();
        }

        public long cont;

        public long getCont()
        {
            return cont;
        }

        public void setCont(long value)
        {
            this.cont = value;
        }

        public void clearEvents()
        {
            menu = false;
            finish = false;
            newGame = false;
            stats = false;
            exitGame = false;
            intro = false;
        }
    }





    public void init()
    {

        this.initialized = true;
        if (this.sCIGms.operationCallback == null)
        {
            Debug.Log("Operation callback for interface sCIGms must be set."); return;

        }

        for (int i = 0; i < 1; i++)
        {
            stateVector[i] = State.gameFlow_null;
        }
        clearEvents();
        clearOutEvents();
        sCIGms.setCont(0);
    }

    public void enter()
    {
        if (!initialized)
        {
            Debug.Log("Stamachine needs to be initialized"); return;
        }
        enterSequence_GameFlow_default();
    }

    public void runCycle()
    {
        if (!initialized) { Debug.Log("Stamachine needs to be initialized"); return; }

        clearOutEvents();
        for (nextStateIndex = 0; nextStateIndex < stateVector.Length; nextStateIndex++)
        {
            switch (stateVector[nextStateIndex])
            {
                case State.gameFlow_Intro:
                    gameFlow_Intro_react(true);
                    break;
                case State.gameFlow_Menu:
                    gameFlow_Menu_react(true);
                    break;
                case State.gameFlow__final_:
                    gameFlow__final__react(true);
                    break;
                case State.gameFlow_New_Game:
                    gameFlow_New_Game_react(true);
                    break;
                case State.gameFlow_Stats:
                    gameFlow_Stats_react(true);
                    break;
                    // gameFlow_null
            }
        }
        clearEvents();


    }
    public void exit()
    {
        exitSequence_GameFlow();
    }

    /**
	 * @see IStatemachine#isActive()
	 */
    public bool isActive()
    {
        return stateVector[0] != State.gameFlow_null;
    }

    /** 
	* @see IStatemachine#isFinal()
	*/
    public bool isFinal()
    {
        return (stateVector[0] == State.gameFlow__final_);
    }
    /**
	* This method resets the incoming events (time events included).
	*/
    protected void clearEvents()
    {
        sCIGms.clearEvents();
    }

    /**
	* This method resets the outgoing events.
	*/
    protected void clearOutEvents()
    {
    }

    /**
	* Returns true if the given state is currently active otherwise false.
	*/
    public bool isStateActive(State state)
    {

        switch (state)
        {
            case State.gameFlow_Intro:
                return stateVector[0] == State.gameFlow_Intro;
            case State.gameFlow_Menu:
                return stateVector[0] == State.gameFlow_Menu;
            case State.gameFlow__final_:
                return stateVector[0] == State.gameFlow__final_;
            case State.gameFlow_New_Game:
                return stateVector[0] == State.gameFlow_New_Game;
            case State.gameFlow_Stats:
                return stateVector[0] == State.gameFlow_Stats;
            default:
                return false;
        }
    }

    public SCIGms getSCIGms()
    {
        return sCIGms;
    }

    /* 'default' enter sequence for state Intro */
    private void enterSequence_GameFlow_Intro_default()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_Intro;
        Debug.Log("Entered Intro");
        gameStateHandler.enterIntro();
    }

    /* 'default' enter sequence for state Menu */
    private void enterSequence_GameFlow_Menu_default()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_Menu;
        gameStateHandler.enterMenu();
    }

    /* Default enter sequence for state null */
    private void enterSequence_GameFlow__final__default()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow__final_;
        gameStateHandler.enterFinalState();
    }

    /* 'default' enter sequence for state New Game */
    private void enterSequence_GameFlow_New_Game_default()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_New_Game;
        gameStateHandler.enterFinalState();
    }

    /* 'default' enter sequence for state Stats */
    private void enterSequence_GameFlow_Stats_default()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_Stats;
        gameStateHandler.enterStatsState();
    }

    /* 'default' enter sequence for region GameFlow */
    private void enterSequence_GameFlow_default()
    {
        react_GameFlow__entry_Default();
    }

    /* Default exit sequence for state Intro */
    private void exitSequence_GameFlow_Intro()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_null;
    }

    /* Default exit sequence for state Menu */
    private void exitSequence_GameFlow_Menu()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_null;
    }

    /* Default exit sequence for final state. */
    private void exitSequence_GameFlow__final_()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_null;
    }

    /* Default exit sequence for state New Game */
    private void exitSequence_GameFlow_New_Game()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_null;
    }

    /* Default exit sequence for state Stats */
    private void exitSequence_GameFlow_Stats()
    {
        nextStateIndex = 0;
        stateVector[0] = State.gameFlow_null;
    }

    /* Default exit sequence for region GameFlow */
    private void exitSequence_GameFlow()
    {
        switch (stateVector[0])
        {
            case State.gameFlow_Intro:
                exitSequence_GameFlow_Intro();
                break;
            case State.gameFlow_Menu:
                exitSequence_GameFlow_Menu();
                break;
            case State.gameFlow__final_:
                exitSequence_GameFlow__final_();
                break;
            case State.gameFlow_New_Game:
                exitSequence_GameFlow_New_Game();
                break;
            case State.gameFlow_Stats:
                exitSequence_GameFlow_Stats();
                break;
            default:
                break;
        }
    }

    /* Default react sequence for initial entry  */
    private void react_GameFlow__entry_Default()
    {
        enterSequence_GameFlow_Intro_default();
    }

    private bool react()
    {
        return false;
    }

    private bool gameFlow_Intro_react(bool try_transition)
    {
        bool did_transition = try_transition;

        if (try_transition)
        {
            if (sCIGms.menu)
            {
                exitSequence_GameFlow_Intro();
                enterSequence_GameFlow_Menu_default();
                react();
            }
            else
            {
                did_transition = false;
            }
        }
        if (did_transition == false)
        {
            did_transition = react();
        }
        return did_transition;
    }

    private bool gameFlow_Menu_react(bool try_transition)
    {
        bool did_transition = try_transition;

        if (try_transition)
        {
            if (sCIGms.exitGame)
            {
                exitSequence_GameFlow_Menu();
                enterSequence_GameFlow__final__default();
            }
            else
            {
                if (sCIGms.newGame)
                {
                    exitSequence_GameFlow_Menu();
                    enterSequence_GameFlow_New_Game_default();
                    react();
                }
                else
                {
                    if (sCIGms.stats)
                    {
                        exitSequence_GameFlow_Menu();
                        enterSequence_GameFlow_Stats_default();
                        react();
                    }
                    else
                    {
                        if (sCIGms.intro)
                        {
                            exitSequence_GameFlow_Menu();
                            enterSequence_GameFlow_Intro_default();
                            react();
                        }
                        else
                        {
                            did_transition = false;
                        }
                    }
                }
            }
        }
        if (did_transition == false)
        {
            did_transition = react();
        }
        return did_transition;
    }

    private bool gameFlow__final__react(bool try_transition)
    {
        bool did_transition = try_transition;

        if (try_transition)
        {
            did_transition = false;
        }
        if (did_transition == false)
        {
            did_transition = react();
        }
        return did_transition;
    }

    private bool gameFlow_New_Game_react(bool try_transition)
    {
        bool did_transition = try_transition;

        if (try_transition)
        {
            if (sCIGms.menu)
            {
                exitSequence_GameFlow_New_Game();
                enterSequence_GameFlow_Menu_default();
                react();
            }
            else
            {
                did_transition = false;
            }
        }
        if (did_transition == false)
        {
            did_transition = react();
        }
        return did_transition;
    }

    private bool gameFlow_Stats_react(bool try_transition)
    {
        bool did_transition = try_transition;

        if (try_transition)
        {
            if (sCIGms.menu)
            {
                exitSequence_GameFlow_Stats();
                enterSequence_GameFlow_Menu_default();
                react();
            }
            else
            {
                did_transition = false;
            }
        }
        if (did_transition == false)
        {
            did_transition = react();
        }
        return did_transition;
    }

    public State getCurrentState()
    {

        return stateVector[0];
    }

}


