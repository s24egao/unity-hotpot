using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour
{
    public int amount = 1;
    public float force = 10;
    public float radius = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        for(int i = 0; i < amount; i++)
        {
            Vector3 position = Random.insideUnitSphere;
            position.Scale(new Vector3(2f, 0f, 2f));
            position += transform.position;

            Collider[] objects;
            objects = Physics.OverlapSphere(position, radius);
            foreach(Collider collider in objects)
                if (collider.GetComponent<Rigidbody>() != null)
                    collider.GetComponent<Rigidbody>().AddExplosionForce(force, position, radius);
        }
    }
}
