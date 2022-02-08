using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple_spawner : MonoBehaviour
{
    public float interval;
    public GameObject prefab;
    void Start()
    {
        Invoke("MakeApple", interval);
    }
    void MakeApple()
    {
        Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
        Invoke("MakeApple", interval);
    }
}
