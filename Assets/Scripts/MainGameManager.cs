using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameMenuFSM menuFSM;
    public GameObject[] menuItems;
    void Start()
    {
        
        menuFSM = new GameMenuFSM();
        menuFSM.MgMan = this;
        menuFSM.setState(MenuFSM.GMENU);

    }

    // Update is called once per frame
    void Update()
    {

    }

    //==============================
    public  void gameExit()
        {
            Debug.Log("Game Exit");
            menuFSM.handleInput(MenuFSM.MenuInput.ExitGame);
            menuItems[4].SetActive(true);
        }

        public  void gameIntro()
        {
            Debug.Log("Game Intro");
            menuFSM.handleInput(MenuFSM.MenuInput.ShowIntro);
            menuItems[1].SetActive(true);
        }

        public  void gameMenu()
        {
            Debug.Log("Game Menu");
             menuFSM.handleInput(MenuFSM.MenuInput.MainMenu);
            menuItems[0].SetActive(true);
        }

        public  void gameStart()
        {
            Debug.Log("Game starting");
              menuFSM.handleInput(MenuFSM.MenuInput.StartGame);
            menuItems[2].SetActive(true);
        }

        public  void gameStats()
        {
               menuFSM.handleInput(MenuFSM.MenuInput.ShowStats);  
              menuItems[3].SetActive(true);
            Debug.Log("Game Stats");
        }

    public void gameUIClear()
        {
           for (int i = 0; i <menuItems.Length; i++)
           {
            menuItems[i].SetActive(false);
           }
        }

}
