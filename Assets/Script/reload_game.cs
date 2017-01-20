using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reload_game : MonoBehaviour {
	void Update  () {  
		if (Input.GetKeyDown (KeyCode.R)) {  
			SceneManager.LoadScene  ("Terrain") ;	}  
	}
}
