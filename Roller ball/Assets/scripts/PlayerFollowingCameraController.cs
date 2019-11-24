using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowingCameraController : MonoBehaviour
{
    /// <summary>
    /// 追逐的玩家的场所
    /// </summary>
    private Transform m_playerTransform;
    /// <summary>
    /// 被写体和相机之间的距离
    /// </summary>
    private Vector3 m_cameraOFFset;


    // Start is called before the first frame update
    void Start()
    {
        
        m_playerTransform = GameObject.Find("Player").transform;

        m_cameraOFFset = this.transform.position - m_playerTransform.position;
    }

    private void LateUpdate()
    {
        if (m_playerTransform != null)
        {
            this.transform.position = m_playerTransform.position + m_cameraOFFset;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
