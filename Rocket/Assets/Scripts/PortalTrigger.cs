using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PortalTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame



    void OnTriggerEnter2D(Collider2D colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        {
            //Fade in, fade out.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Trigger");
        }

    }


}
