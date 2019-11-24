using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IngameTextManager : MonoBehaviour
{

    public TextMeshProUGUI ResultText;

    public static IngameTextManager Instance = null;

    private void Awake()
    {
        Instance = this;
        ResultText.text = string.Format("{00:00}", InGameStateManager.Instance.CoinCnt);
    }

    public void Coinsubtract()
    {
        InGameStateManager.Instance.CoinCnt-= 1;
        {
            ResultText.text = string.Format("{00:00}", InGameStateManager.Instance.CoinCnt);
        }
    }

    public void Enemysubtract()
    {
        InGameStateManager.Instance.EnemyCnt -= 1;
    }

   
}
