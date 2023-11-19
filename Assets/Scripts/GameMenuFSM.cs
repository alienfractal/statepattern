

using UnityEngine;
namespace FSMMenuSys
{
    public class GameMenuFSM : MenuFSM
    {
        private MainGameManager mgMan;
        public GameMenuFSM()
        {

        }

        public override void gameExit()
        {
      
             MgMan.gameExit();
        }

        public override void gameIntro()
        {
         
            MgMan.gameIntro();
        }

        public override void gameMenu()
        {
           
             MgMan.gameMenu();
        }

        public override void gameStart()
        {
         
            MgMan.gameStart();
        }

        public override void gameStats()
        {
          
            MgMan.gameStats();
        }

        public override void gameUIClear()
        {
          
            MgMan.gameUIClear();
        }

        public MainGameManager MgMan { get => mgMan; set => mgMan = value; }
    }
}
