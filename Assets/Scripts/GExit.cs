using FSMMenuSys;

public class GExit : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
         menuFSM.gameExit();
    }

    public void exit(MenuFSM menuFSM)
    {
         menuFSM.gameUIClear();
    }

    public void handleNextState(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
        //menuFSM.setState(MenuFSM.GEXIT);
    }
}