namespace FSMMenuSys
{

    public interface IMenuState
    {
        void enter(MenuFSM menuFSM);
        void transition(MenuFSM menuFSM,MenuFSM.MenuInput state);

    }
}
