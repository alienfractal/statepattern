using UnityEngine;
public class GameMenuCallback : SCIGmsOperationCallback
{
    public void display(string currentState)
    {
        Debug.Log(" STATE =  "+currentState);
    }
}