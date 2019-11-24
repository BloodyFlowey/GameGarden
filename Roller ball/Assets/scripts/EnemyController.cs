using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform m_EnemyTrasform;
    public Transform Target;
    private Vector3 m_rollVector = new Vector3();
    float speed = 0.9f;

    float lifetime;

    // Start is called before the first frame update
    void Start()
    {
        Target = InGameStateManager.Instance.Player.transform;
        lifetime = PlayerPrefs.GetFloat(SaveDataManager.EnemyLifeTimeSaveKey);
        m_EnemyTrasform = this.transform;
        m_rollVector.y = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime<0) {

            Destroy(this.gameObject);
        }

        m_EnemyTrasform.Rotate(m_rollVector * Time.deltaTime);
        Vector3 dir = (Target.position - this.transform.position);
        if (dir.magnitude < 0.1)
        {
            Destroy(this.gameObject);
        }
        this.transform.rotation = Quaternion.FromToRotation(Vector3.left, dir);
        this.transform.position += speed * Time.deltaTime * dir.normalized;
    }


    void OnTriggerEnter(Collider other)
    {
        IngameTextManager.Instance.Enemysubtract();
        this.gameObject.SetActive(false);
    }
}
