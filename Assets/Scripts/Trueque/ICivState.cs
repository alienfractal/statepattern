public interface ICivState
{
    // Start is called before the first frame update
    void enter(CivFSM civFSM);
    void transition(CivFSM civFSM, CivFSM.CivInput state);

}
