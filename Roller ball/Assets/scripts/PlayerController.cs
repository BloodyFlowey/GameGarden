using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody m_rigidbody;

    private Vector3 m_moveVector = new Vector3();

    public float MoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        m_moveVector.z = Input.GetAxis("Vertical");
        m_moveVector.x = Input.GetAxis("Horizontal");  
    }

    private void FixedUpdate()
    {
        if (m_rigidbody != null)
        { 
            m_rigidbody.AddForce(m_moveVector * MoveSpeed, ForceMode.Acceleration);
        }
 
    }
}
