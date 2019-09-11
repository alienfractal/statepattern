using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateHandler : MonoBehaviour
{
    public enum GAME_STATE { INTRO, MENU, STATS, GAME, WIN, FAIL, END }
    public GAME_STATE CURRENT_GAME_STATE;

    public GameObject[] STATES;

    // Start is called before the first frame update
    void Start()
    {
        CURRENT_GAME_STATE = GAME_STATE.INTRO;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void valideGameState()
    {

        for (int i = 0; i < STATES.Length; i++)
        {
            if (STATES[i] != null)
            {
                if (i == (int)CURRENT_GAME_STATE)
                {
                    STATES[i].SetActive(true);
                }
                else{
                    STATES[i].SetActive(false);
                }
                

            }

        }

    }

    public void setNextState(GAME_STATE NEXT_GAME_STATE)
    {
        CURRENT_GAME_STATE = NEXT_GAME_STATE;
        valideGameState();
    }

}
