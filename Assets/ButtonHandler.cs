using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameStateHandler gameStateHandler;

    

    // Start is called before the first frame update
    void Start()
    {
        gameStateHandler = FindObjectOfType<GameStateHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setNextState(int NEXT_GAME_STATE)
    {   //Debug.Log("CLICK "+NEXT_GAME_STATE+" "+((GameStateHandler.GAME_STATE)NEXT_GAME_STATE));
       // gameStateHandler.setNextState((gameStateHandler.getGamemodelStatemachine().setNextState())NEXT_GAME_STATE);
    }
}
