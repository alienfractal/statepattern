 

public interface StateFlow : IStatemachine
{
     SCIGms getSCIGms();

}

public interface SCIGms
{

     void raiseMenu();

     void raiseFinish();

     void raiseNewGame();

     void raiseStats();

     void raiseExitGame();

     void raiseIntro();

     void raiseWinLevel();

     void raiseWinGame();

     void raiseGameOver();

     long getCont();

     void setCont(long value);

     void setSCIGmsOperationCallback(SCIGmsOperationCallback operationCallback);

}

public interface SCIGmsOperationCallback
{

     void display(string value);

}
