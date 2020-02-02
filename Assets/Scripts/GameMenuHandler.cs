using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameMenuHandler : MonoBehaviour
{
    public GameMenuFSM menuFSM;
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