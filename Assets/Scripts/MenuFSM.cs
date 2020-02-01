public abstract class MenuFSM
{

    private MenuState state;

    public void intro()
    {

    }
    public void menu() { }
    public void newgame() { }
    public void stats() { }
    public void exitgame() { }

    public void setState(MenuState _state)
    {
        this.state = _state;

    }

    public abstract void loadIntro();
    public abstract void loadMenu();

    public abstract void loadNewGame();

    public abstract void loadStats();

    public abstract void loadExitGame();



}