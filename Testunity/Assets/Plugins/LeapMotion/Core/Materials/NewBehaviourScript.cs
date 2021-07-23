using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    public float rotateSpeed;

    /* MeshRenderer mesh;
     Material mat;
     private Rigidbody rb;*/

    void Update()
    {
    //    transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
    /*void Start()
    {
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hand Model")
            mat.color = new Color(0, 0, 0);
    }*/
}
