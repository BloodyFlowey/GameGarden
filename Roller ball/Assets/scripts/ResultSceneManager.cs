using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultSceneManager : MonoBehaviour
{
    ///<summary>
    ///设定scene移动的按钮
    ///</summary>

    public Button NextSceneButton;

    public TextMeshProUGUI ResultText;
    public TextMeshProUGUI ScoreText;
    private string YourScore = "YourScore";
    public RawImage PictureRawImage;

    private void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.START_SCENE_NAME));
        //表示物的初期化
        ResultText.text = string.Empty;
        ScoreText.text = string.Empty;

        if (PlayerPrefs.GetInt(SaveDataManager.ResultSaveKey) == 1)
        {
            ResultText.text = "GAMEOVER";
        }
        else
        {
            ResultText.text = "GAMECLEAR";
            ScoreText.text = string.Format("{0}:{1:00}", YourScore, PlayerPrefs.GetFloat(SaveDataManager.ScoreSaveKey));
        }
        PictureRawImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);

    }
    
}
