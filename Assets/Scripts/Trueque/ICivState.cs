public interface ICivState
{
    // Start is called before the first frame update
    void enter(CivFSM civFSM);
    void exit(CivFSM civFSM);

    void handleNextState(CivFSM menuFSM, CivFSM.CivInput state); 
    }
