public abstract class SimpleMenuState : MenuState
{

    public static Menu MENU = new Menu();
    public static Intro INTRO = new Intro();
    
    public static Stats STATS = new Stats();

    public static NewGame NEWGAME = new NewGame();

    public static ExitGame EXITGAME = new ExitGame();
    



    public abstract void exitgame(MenuFSM menuFSM);
    public abstract void intro(MenuFSM menuFSM);
    public abstract void menu(MenuFSM menuFSM);
    public abstract void newgame(MenuFSM menuFSM);
    public abstract void stats(MenuFSM menuFSM);
}