using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameStartState : IState
{
    public void Enter()
    {
        SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME);
    }

    public void Exit()
    {
        ///如果想要退出的时候在这里记述
    }

    public void Update()
    {
        InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.Gamestateprocesser.GAMEMAIN);
    }

    
}
