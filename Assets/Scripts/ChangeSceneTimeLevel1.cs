using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class ChangeSceneTimeLevel1 : MonoBehaviour
 {
     public float delay = 5;
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(3);
     }
 }