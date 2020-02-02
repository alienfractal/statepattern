public class ExitGame : SimpleMenuState
{
    public override void exitgame(MenuFSM menuFSM)
    {
        menuFSM.setState(EXITGAME);
        menuFSM.loadExitGame();
    }

    public override void intro(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }

    public override void menu(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }

    public override void newgame(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }

    public override void stats(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }
}