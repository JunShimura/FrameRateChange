using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveObject : MonoBehaviour
{
    [SerializeField]
    Vector3 initialForce = Vector3.right;
    Vector3 initialPos = Vector3.zero;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnBecameInvisible()
    {
        transform.position = initialPos;
        rb.velocity = initialForce;
    }
}
