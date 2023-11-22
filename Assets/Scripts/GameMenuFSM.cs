

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
            transition(MenuInput.ExitGame);
            enter();

        }

        public override void gameIntro()
        {
            transition(MenuInput.ShowIntro);
            enter();

        }

        public override void gameMenu()
        {
            transition(MenuInput.MainMenu);
            enter();


        }

        public override void gameStart()
        {
            transition(MenuInput.StartGame);
            enter();

        }

        public override void gameStats()
        {

            transition(MenuInput.ShowStats);
            enter();
        }

        public override void gameUIClear()
        {
            MgMan.gameUIClear();
        }

        public MainGameManager MgMan { get => mgMan; set => mgMan = value; }
    }
}
