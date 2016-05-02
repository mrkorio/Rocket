using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Use this for initialization
    private float fadeTime;
     
	void Start () {

      

        
	}

    public static IEnumerator ChangeLevel(float fadeTime)
    {
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
