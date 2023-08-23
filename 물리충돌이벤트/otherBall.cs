using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherBall: MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ball")
        {
            mat.color = new Color(0, 0, 0);
        }
    }

}
