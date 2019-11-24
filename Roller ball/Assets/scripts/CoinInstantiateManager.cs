using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstantiateManager : MonoBehaviour
{
    /// <summary>
    /// 设定CoinRoot
    /// </summary>
    public GameObject CoinRoot = null;

    /// <summary>
    /// 用于作成CoinRoot的位置设定用的配列
    /// </summary>
    public Vector3[] CoinPos = new Vector3[8];

    // Start is called before the first frame update
    void Start()
    {
     for(int i = 0; i < CoinPos.Length; i++)
        {
            ///GameObject的做成
            Instantiate(CoinRoot, CoinPos[i], Quaternion.identity, this.transform);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
