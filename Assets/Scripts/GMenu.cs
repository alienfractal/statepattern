using FSMMenuSys;
public class GMenu : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
       menuFSM.gameMenu();
    }

    public void exit(MenuFSM menuFSM)
    {
       menuFSM.gameUIClear();
    }

    public void handleNextState(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
         switch(state)
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
        
    }
}