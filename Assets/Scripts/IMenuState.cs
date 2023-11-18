namespace FSMMenuSys
{

    public interface IMenuState
    {
        void enter(MenuFSM menuFSM);
        void exit(MenuFSM menuFSM);

        void handleTransition(MenuFSM menuFSM,MenuFSM.MenuInput state);

    }
}
