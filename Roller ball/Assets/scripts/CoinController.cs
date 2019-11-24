using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private Transform m_CoinTrasform;

    private Vector3 m_rollVector = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        m_CoinTrasform = this.transform;
        m_rollVector.y = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        m_CoinTrasform.Rotate(m_rollVector * Time.deltaTime); 
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<EffectManager>().EffectPlay();
        IngameTextManager.Instance.Coinsubtract();
        SoundManager.Instance.PlaySESound(SoundManager.COINSE_NAME);
        this.gameObject.SetActive(false);
    }
}
