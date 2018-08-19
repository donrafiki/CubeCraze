using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverFall : MonoBehaviour
{

    void Update()
    {
        if (transform.position.y < -80)
        {
            SceneManager.LoadScene(2);
        }
    }
}
