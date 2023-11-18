

using UnityEngine;

public class GameMenuFSM : MenuFSM
{
    public override void gameExit()
    {
       Debug.Log("Game Exit");
    }

    public override void gameIntro()
    {
         Debug.Log("Game Intro");
    }

    public override void gameMenu()
    {
          Debug.Log("Game Menu");
    }

    public override void gameStart()
    {
        Debug.Log("Game starting");
    }

    public override void gameStats()
    {
       Debug.Log("Game Stats");
    }
}
