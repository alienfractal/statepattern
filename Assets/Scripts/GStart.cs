using FSMMenuSys;
public class GStart : IMenuState
{
    public void enter(MenuFSM menuFSM)
    {
        //throw new System.NotImplementedException();
        menuFSM.gameStart();
    }

    public void exit(MenuFSM menuFSM)
    {
         
    }

    public void handleTransition(MenuFSM menuFSM, MenuFSM.MenuInput state)
    {
        
    }
}