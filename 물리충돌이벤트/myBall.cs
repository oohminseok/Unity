using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myBall : MonoBehaviour
{ 
    Rigidbody rigid;

    void Start()
    {
        rigid=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //rigid.velocity=new Vector3(2,1,3);
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }
}
