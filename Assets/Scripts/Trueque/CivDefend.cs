public class CivDefend : ICivState
{
    public void enter(CivFSM civFSM)
    {
        civFSM.ACTIONS += "D";
    }

    public void transition(CivFSM civFSM, CivFSM.CivInput state)
    {
        switch (state)
        {
            case CivFSM.CivInput.Update:
                civFSM.setState(CivFSM.CIVUPDATE);
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