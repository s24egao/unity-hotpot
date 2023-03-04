using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[RequireComponent(typeof(Rigidbody))]
public class Food : MonoBehaviour
{
    public float force;
    public float height;

    bool inSoup;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(inSoup) rb.AddForce(Vector3.up * Mathf.Clamp(height - transform.position.y, 0, 1f) * force, ForceMode.Force);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Soup") inSoup = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Soup") inSoup = false;
    }
}
