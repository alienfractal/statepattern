public abstract class MenuFSM
{

    private MenuState state;

    public void intro()
    {
        this.state.intro(this);
    }
    public void menu()
    {
        this.state.menu(this);
    }
    public void newgame()
    {
        this.state.newgame(this);
    }
    public void stats()
    {
        this.state.stats(this);
    }
    public void exitgame()
    {
        this.state.exitgame(this);
    }

    public void setState(MenuState _state)
    {
        this.state = _state;

    }

    public MenuState getState()
    {
        return this.state;

    }
    //All the FSM actions are described below. 
    public abstract void loadIntro();
    public abstract void loadMenu();
    public abstract void loadNewGame();
    public abstract void loadStats();
    public abstract void loadExitGame();



}