using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWinLevel2 : MonoBehaviour
{

    void Update()
    {
        if (transform.position.z > 10000 && transform.position.z < 620 && transform.position.y > -1 && transform.position.x > -20 && transform.position.x < 20)
        {
            SceneManager.LoadScene(6);
        }
    }
}