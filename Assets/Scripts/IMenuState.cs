namespace FSMMenuSys
{

    public interface IMenuState
    {
        void enter(MenuFSM menuFSM);
        void exit(MenuFSM menuFSM);

        void handleNextState(MenuFSM menuFSM,MenuFSM.MenuInput state);

    }
}
