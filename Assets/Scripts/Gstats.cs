using FSMMenuSys;

public class Gstats : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
        menuFSM.gameStats();
    }

    public void exit(MenuFSM menuFSM)
    {
        menuFSM.gameUIClear();
    }

    public void handleNextState(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
        switch (state)
        {

            case MenuFSM.MenuInput.MainMenu:
                menuFSM.setState(MenuFSM.GMENU);
                break;
        }
    }
}