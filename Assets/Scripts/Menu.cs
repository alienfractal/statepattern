public class Menu : SimpleMenuState
{
    public override void exitgame(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }

    public override void intro(MenuFSM menuFSM)
    {
        throw new System.NotImplementedException();
    }

    public override void menu(MenuFSM menuFSM)
    {
        menuFSM.setState(MENU);
        menuFSM.loadMenu();
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