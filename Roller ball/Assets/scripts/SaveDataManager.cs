using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : SingletonBase<SaveDataManager>
{
    public const string ResultSaveKey = "Result";
    public const string ScoreSaveKey = "Score";

    public const string EnemyCountSaveKey = "EnemyCount";
    public const string EnemyLifeTimeSaveKey = "EnemyLife";
    public const string GameTimeSaveKey = "GameTime";

    protected override void Awake()
    {
        base.Awake();
    }

    ///<summary>
    ///Save游戏结果
    ///</summary>
    ///<param name="_ResultTime">通关时所剩的时间
    ///<param name="_GameOver">保存0或者1 0=游戏CLEAR，1=GAMEOVER>
    public void SaveGameData(float _ResultTime, int _GameOver)
    {
        PlayerPrefs.SetInt(ResultSaveKey, _GameOver);
        PlayerPrefs.SetFloat(ScoreSaveKey, _ResultTime);
        PlayerPrefs.Save();
    }


    public void SaveGameSettingData(int _enemyCount, float _enemyLifeTime, float _gameTime)
    {
        PlayerPrefs.SetInt(EnemyCountSaveKey, _enemyCount);
        PlayerPrefs.SetFloat(EnemyLifeTimeSaveKey, _enemyLifeTime);
        PlayerPrefs.SetFloat(GameTimeSaveKey, _gameTime);
        PlayerPrefs.Save();

    }
}
