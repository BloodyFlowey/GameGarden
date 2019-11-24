using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameInitState : IState
{
    public void Enter()
    {
        Debug.Log("InitStart");
        InGameStateManager.Instance.Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    public void Update()
    {
        InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.Gamestateprocesser.START);
    }

    public void Exit()
    {
        ///如果想要退出的时候在这里记述
    }
}
