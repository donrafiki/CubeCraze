using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCollision : MonoBehaviour {

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "ObstacleB")
        {
            SceneManager.LoadScene(4);
        }
	}
}
