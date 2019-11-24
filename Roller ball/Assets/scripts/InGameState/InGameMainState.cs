using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMainState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;

    private bool m_stateEnd = false;

    public void Enter()
    {
        Debug.Log("GameMainStart");
    }

    public void Update()
    {
        stateManager.GameTime -= Time.deltaTime;
        //IngameTextManager.Instance.TimeCountTextShow();
            if (stateManager.GameTime < 0)
            {
                stateManager.GameOver = true;
                m_stateEnd = true;
            }
            if (stateManager.Player.transform.position.y < -2)
            {
                stateManager.GameOver = true;
                m_stateEnd = true;
            }
            if (stateManager.CoinCnt == 0)
            {
                stateManager.GameOver = false;
                m_stateEnd = true;
            }
            if (stateManager.EnemyCnt < 2)
            {
                stateManager.GameOver = true;
                m_stateEnd = true;
            }
            if(m_stateEnd == true)
            {
                InGameStateManager.Instance.stateMachine.SetState(InGameStateManager.Gamestateprocesser.RESULT);
            }
    }


    public void Exit()
    {
        // 如果想要退出的时候在这里记述
    }
}
