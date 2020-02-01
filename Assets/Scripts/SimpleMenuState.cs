public abstract class SimpleMenuState : MenuState
{

    public static Menu MENU = new Menu();
    public static Intro INTRO = new Intro();

    public abstract void exitgame(MenuFSM menuFSM);
    public abstract void intro(MenuFSM menuFSM);
    public abstract void menu(MenuFSM menuFSM);
    public abstract void newgame(MenuFSM menuFSM);
    public abstract void stats(MenuFSM menuFSM);
}