public class Menu : SimpleMenuState
{
    public override void exitgame(MenuFSM menuFSM)
    {
        menuFSM.setState(EXITGAME);
        menuFSM.loadExitGame();
    }

    public override void intro(MenuFSM menuFSM)
    {
        menuFSM.setState(INTRO);
        menuFSM.loadIntro();
    }

    public override void menu(MenuFSM menuFSM)
    {
        menuFSM.setState(MENU);
        menuFSM.loadMenu();
    }

    public override void newgame(MenuFSM menuFSM)
    {
        menuFSM.setState(NEWGAME);
        menuFSM.loadNewGame();
    }

    public override void stats(MenuFSM menuFSM)
    {
        menuFSM.setState(STATS);
        menuFSM.loadStats();
    }
}