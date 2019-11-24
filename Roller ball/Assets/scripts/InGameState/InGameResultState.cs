using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameResultState : IState
{
    private InGameStateManager stateManager = InGameStateManager.Instance;

    private bool m_gameEnd = false;

    public void Enter()
    {
        if (stateManager.GameOver)
        {
            MonoBehaviour.Destroy(stateManager.Player.gameObject);
            SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME1);
        }
        else
        {

            SoundManager.Instance.PlayBGMSound(SoundManager.BGM_NAME2);
        }

        ///save data
        SaveDataManager.Instance.SaveGameData(stateManager.GameTime, System.Convert.ToInt32(stateManager.GameOver));

        SceneControllManager.Instance.GotoNextScene(SceneControllManager.RSEULT_SCENE_NAME);
    }
    public void Update()
    {
        if (!m_gameEnd)
        {
            m_gameEnd = true;
        }
    }

    public void Exit()
    {
       
    }


}
