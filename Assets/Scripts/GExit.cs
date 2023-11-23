using FSMMenuSys;

public class GExit : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
         menuFSM.ACTIONS+="E";
    }

    public void transition(MenuFSM menuFSM,MenuFSM.MenuInput state)
    {
         menuFSM.gameUIClear();
    }

   
}