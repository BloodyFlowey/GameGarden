using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartSceneManager : MonoBehaviour
{
    ///<summary>
    ///设定scene移动的按钮
    ///</summary>

    public Button NextSceneButton;

    public RawImage VideoRawImage;

    public TextMeshProUGUI TitleText;

    private Material m_titleMaterial;

    private void Start()
    {
        NextSceneButton.onClick.AddListener(() => SceneControllManager.Instance.GotoNextScene(SceneControllManager.SELECT_SCENE_NAME));
        VideoRawImage.rectTransform.sizeDelta = new Vector2(Screen.width, Screen.height);
        m_titleMaterial = TitleText.fontMaterial;
        SoundManager.Instance.StopBGMSound(SoundManager.BGM_NAME1);
        SoundManager.Instance.StopBGMSound(SoundManager.BGM_NAME2);
    }

    private void Update()
    {
        m_titleMaterial.SetColor("_FaceColor", new Color(1, 1, 1, Mathf.Sin(Time.time) / 0.5f));
        m_titleMaterial.SetColor("_OutLineColor", new Color(0, 0, 0, Mathf.Sin(Time.time) / 0.5f));
    }
}
