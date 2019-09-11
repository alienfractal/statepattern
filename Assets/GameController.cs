using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameStateHandler gameStateHandler;

    // Start is called before the first frame update
    void Start()
    {
        gameStateHandler.valideGameState();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
