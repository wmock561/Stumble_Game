using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {

	private float fallDelay = 7;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other){

		roadManager.Instance.SpawnTile ();
		StartCoroutine (FallDown ());
	}

	IEnumerator FallDown(){
		yield return new WaitForSeconds (fallDelay);
		GetComponent<Rigidbody> ().isKinematic = false;
		yield return new WaitForSeconds (2);

		switch(gameObject.name){

		case "NextTile":
			roadManager.Instance.Roads.Push (gameObject);
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			gameObject.SetActive (false);
			break;
		default:

			break;

		}
	}
}





