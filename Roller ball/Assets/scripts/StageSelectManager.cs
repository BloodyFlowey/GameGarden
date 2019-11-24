using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectManager : MonoBehaviour
{
    ///<summary>
    ///设定scene移动的按钮
    ///</summary>

    public Button[] NextSceneButton = new Button[3];

    private void Start()
    {
        GameSetting easy = new GameSetting(1, 2, 60);
        GameSetting normal = new GameSetting(2, 4, 50);
        GameSetting hard = new GameSetting(3, 6, 40);

        for (int i = 0; i < 3; i++)
        {
            NextSceneButton[i].onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.INGAME_SCENE_NAME));
        }
        NextSceneButton[0].onClick.AddListener(() =>SaveDataManager.Instance.SaveGameSettingData(easy.EnemyCount,easy.EnemyLifeTime,easy.GameTime));
        NextSceneButton[1].onClick.AddListener(() => SaveDataManager.Instance.SaveGameSettingData(normal.EnemyCount, normal.EnemyLifeTime, normal.GameTime));
        NextSceneButton[2].onClick.AddListener(() => SaveDataManager.Instance.SaveGameSettingData(hard.EnemyCount, hard.EnemyLifeTime, hard.GameTime));
    }

    private struct GameSetting
    {
        public int EnemyCount;
        public float EnemyLifeTime;
        public float GameTime;
        public GameSetting(int _enemyCount, float _enemyLifeTime, float _gameTime)
        {
            EnemyCount = _enemyCount;
            EnemyLifeTime = _enemyLifeTime;
            GameTime = _gameTime;
        }
    }

}
