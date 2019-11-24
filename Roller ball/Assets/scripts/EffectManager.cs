using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{

    /// <summary>
    /// 特效的母特效
    /// </summary>
    public GameObject Effect;

    /// <summary>
    /// 特效的游玩关数
    /// </summary>
    // Start is called before the first frame update
    public void EffectPlay()
    {
        foreach (var particles in Effect.GetComponentsInChildren<ParticleSystem>())
        {
            if (particles == null)
            {
                Debug.Log("没有效果！");
            }
            else
            {
                particles.Play();
            }
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
