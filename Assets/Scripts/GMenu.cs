using FSMMenuSys;
public class GMenu : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
       
    }

    public void exit(MenuFSM menuFSM)
    {
       
    }

    public void handleTransition(MenuFSM menuFSM, MenuFSM.MenuInput state)
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
            case MenuFSM.MenuInput.MainMenu:
                menuFSM.setState(MenuFSM.GMENU);
                break;    
        }
        
    }
}