using FSMMenuSys;
public class GMenu : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
        menuFSM.ACTIONS+="M";
    }

    public void transition(MenuFSM menuFSM,MenuFSM.MenuInput state)
    {
        switch (state)
        {
            case MenuFSM.MenuInput.StartGame:
                menuFSM.setState(MenuFSM.GSTART);
                break;
            case MenuFSM.MenuInput.ShowIntro:
                menuFSM.setState(MenuFSM.GINTRO);
                break;
            case MenuFSM.MenuInput.ShowStats:
                menuFSM.setState(MenuFSM.GSTATS);
                break;
            case MenuFSM.MenuInput.ExitGame:
                menuFSM.setState(MenuFSM.GEXIT);
                break;

        }
        menuFSM.gameUIClear();
    }

}