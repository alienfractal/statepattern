using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameMenuFSM menuFSM;
    void Start()
    {
        menuFSM = new GameMenuFSM();
        menuFSM.setState(MenuFSM.GMENU);
        menuFSM.handleInput(MenuFSM.MenuInput.MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
