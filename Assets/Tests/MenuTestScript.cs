using System.Collections;
using System.Collections.Generic;
using FSMMenuSys;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MenuTestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void MenuTestScriptSimplePasses()
    {
        // Use the Assert class to test conditions
         Debug.Log("Test is running");
        GameMenuFSM gFsm = new GameMenuFSM();
         
         gFsm.setState(MenuFSM.GMENU);
         gFsm.handleInput(MenuFSM.MenuInput.StartGame);
         Assert.AreEqual(MenuFSM.GSTART, gFsm.getState());

    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator MenuTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
