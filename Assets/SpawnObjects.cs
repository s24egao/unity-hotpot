using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] objects;
    public KeyCode key = KeyCode.S;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(key))
        {
            GameObject newObject = Instantiate(objects[Random.Range(0, objects.Length)], transform.position, Quaternion.Euler(Vector3.zero));
            newObject.transform.localScale *= Random.Range(0.9f, 1.2f);
        }
    }
}
