using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using UnityEngine;

public class TestProgram : MonoBehaviour
{
     private GameMenuFSM menuFSM;
    // Start is called before the first frame update
    void Start()
    {
         menuFSM = new GameMenuFSM();
        // Start with the main menu
        menuFSM.setState(GameMenuFSM.GMENU);
        menuFSM.enter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
