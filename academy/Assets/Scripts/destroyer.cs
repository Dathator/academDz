using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyer : MonoBehaviour
{
    public GameObject[] list = new GameObject[3];
    static int count = 0;

    private void Start()
    {
        
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.tag == "apple")
        {
            Destroy(myCollision.gameObject);
            Destroy(list[count]);
            count++;
            if (count > 2)
            {
                count = 0;
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(0);
                SceneManager.UnloadSceneAsync(scene);
            }
        }
    }
}
