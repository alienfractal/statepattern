using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private MenuFSM menuFSM;
    void Start()
    {
        menuFSM = new GameMenuFSM();
        menuFSM.gameIntro();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
