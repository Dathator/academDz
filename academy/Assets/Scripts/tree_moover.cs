using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree_moover : MonoBehaviour
{
    public float start_speed;
    private int rand;
    private int rand2;
    private bool flag = false;
    private void Start()
    {
        rand = Random.Range(-10, 10);
    }
    void Update()
    {
        if ((gameObject.transform.position.x > 10 || gameObject.transform.position.x < -10) && (!flag))
        {
            start_speed = -start_speed;
            flag = true;
        }
        else if ((gameObject.transform.position.x < 10 || gameObject.transform.position.x > -10) && flag)
        {
            flag = false;
        }
        rand2 = Random.Range(1, 4);
        if (((rand >= 0 && gameObject.transform.position.x > rand) || (rand <= 0 && gameObject.transform.position.x < rand)) && rand2 == 2)
        {
            start_speed = -start_speed;
            rand = Random.Range(-10, 10);
        }
        transform.Translate(new Vector3(start_speed, 0, 0) * Time.deltaTime);
    }
}
