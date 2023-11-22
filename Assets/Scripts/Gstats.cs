using FSMMenuSys;

public class Gstats : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
         menuFSM.ACTIONS+="T";
    }

    public void transition(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
         switch (state)
        {

            case MenuFSM.MenuInput.MainMenu:
                menuFSM.setState(MenuFSM.GMENU);
                break;
        }
        menuFSM.gameUIClear();
    }

   
}