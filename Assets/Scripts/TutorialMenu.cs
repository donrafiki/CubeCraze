using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour {

    public void TutorialGame()
    {
        SceneManager.LoadScene(2);
    }

    public void GamePlay()
    {
        SceneManager.LoadScene(3);
    }
}