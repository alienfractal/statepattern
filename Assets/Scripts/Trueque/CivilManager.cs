using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivilManager : MonoBehaviour
{
    // Start is called before the first frame update
    public MuiscaFSM muiscaciv;
    public MuiscaFSM muiscaciv2;
    public void gameDefend()
    {
       
    }

    public void gameIdle(CivFSM civ)
    {
        
    }

    public void gameTrade()
    {
        throw new System.NotImplementedException();
    }

    public void gameUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void updateUI()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        muiscaciv = new MuiscaFSM("Bacata",
         100, (float)300.0, (float)130.0, (float)80.0, (float)93.0, 1, 1, 1, 1, 1);
        muiscaciv.CivMan = this;
        muiscaciv.setState(CivFSM.CIVIDLE);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
