using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    int EnemyCount;
    public GameObject Enemy;
    Vector3[] EnemyPos;

    // Start is called before the first frame update
    void Start()
    {
        EnemyCount = PlayerPrefs.GetInt(SaveDataManager.EnemyCountSaveKey);
        EnemyPos = new Vector3[EnemyCount];
        for (int i = 0; i < EnemyCount; i++)
        {
            EnemyPos[i].x = Random.Range(-6f, 6f);
            EnemyPos[i].z = Random.Range(-6f, 6f);
            EnemyPos[i].y = -0.6f;

            Instantiate(Enemy, EnemyPos[i], Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
