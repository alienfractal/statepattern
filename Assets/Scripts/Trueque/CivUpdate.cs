public class CivUpdate : ICivState
{
    public void enter(CivFSM civFSM)
    {
        civFSM.ACTIONS+="U";
    }

    public void transition(CivFSM civFSM, CivFSM.CivInput state)
    {
        switch (state)
        {
            case CivFSM.CivInput.Idle:
                civFSM.setState(CivFSM.CIVIDLE);
                break;
            case CivFSM.CivInput.Defend:
                civFSM.setState(CivFSM.CIVDEFEND);
                break;
            case CivFSM.CivInput.Trade:
                civFSM.setState(CivFSM.CIVTRADE);
                break;
        }
        civFSM.updateUI();
    }

}