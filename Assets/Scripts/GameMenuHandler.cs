using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenuHandler : MonoBehaviour
{
    public GameMenuFSM menuFSM;
    /**
    *This array is used to hold objects that should be acive when the FSM
    *moves to an state.
    */
     public GameObject[] stateGameObjects;
    // Start is called before the first frame update
    void Start()
    {
        menuFSM = new GameMenuFSM(this);
        menuFSM.Start();

    }

    // Update is called once per frame
    void Update()
    {

    }


}