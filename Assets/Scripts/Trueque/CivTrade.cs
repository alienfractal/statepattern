public class CivTrade : ICivState
{
    public void enter(CivFSM civFSM)
    {
     civFSM.ACTIONS+="T";
    }

    public void transition(CivFSM civFSM, CivFSM.CivInput state)
    { switch (state)
        {

            case CivFSM.CivInput.Update:
                civFSM.setState(CivFSM.CIVUPDATE);
                break;

        }
        civFSM.updateUI();
    }




}