using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControllManager : SingletonBase<SceneControllManager>
{

    public const string START_SCENE_NAME = "Start";
    public const string SELECT_SCENE_NAME = "StageSelect";
    public const string INGAME_SCENE_NAME = "GameMain";
    public const string RSEULT_SCENE_NAME = "Result";

    private string CurrentSceneName = string.Empty;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        CurrentSceneName = SceneManager.GetActiveScene().name;
    }

    public void GotoNextScene(string _nextScene, bool _additive = false, string _additiveScene = null)
    {
        CurrentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(_nextScene);
        if (_additive)
        {
            if (string.IsNullOrEmpty(_additiveScene))
            {
                return;
            }
            SceneManager.LoadScene(_additiveScene, LoadSceneMode.Additive);
        }
    }

    public void ReturnBackScene()
        {
           SceneManager.LoadScene(CurrentSceneName);

        }

    public void GotoNextScene(string _NextScene)
    {
        SceneManager.LoadScene(_NextScene);
    }

}
