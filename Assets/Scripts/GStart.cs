using FSMMenuSys;
public class GStart : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
        
         menuFSM.ACTIONS+="S";
    }

    public void transition(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
          switch(state)
        {
           
            case MenuFSM.MenuInput.MainMenu:
                menuFSM.setState(MenuFSM.GMENU);
                break;    
        }
         menuFSM.gameUIClear();
    }

}