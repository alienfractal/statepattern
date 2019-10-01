using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public GameStateHandler gameStateHandler;

    public GameStateHandler.UISateGameObject nextState;



    // Start is called before the first frame update
    void Start()
    {
        gameStateHandler = FindObjectOfType<GameStateHandler>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setNextState()
    {
        gameStateHandler.setNextState(nextState);
    }
}
