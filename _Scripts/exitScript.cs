using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class exitScript : MonoBehaviour {

	public void StartLevel(){

		SceneManager.LoadScene (1);
	}

	public void ExitGame(){
		SceneManager.LoadScene (0);
	}
}
