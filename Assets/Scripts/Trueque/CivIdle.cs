public class CivIdle : ICivState
{
    public void enter(CivFSM civFSM)
    {
       civFSM.gameIdle();
    }

    public void exit(CivFSM civFSM)
    {
       civFSM.updateUI();
    }

    public void handleNextState(CivFSM menuFSM, CivFSM.CivInput state)
    {
        throw new System.NotImplementedException();
    }
}