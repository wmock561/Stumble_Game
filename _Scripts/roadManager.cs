using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class roadManager : MonoBehaviour {


	public GameObject nextTilePrefab;
	public GameObject currentTile;

	private Stack<GameObject> roads = new Stack<GameObject>();

	public Stack<GameObject> Roads {
		get{ return roads; }
		set{ roads = value; }
	}

	private static roadManager instance;

	public static roadManager Instance {
		get {
			if (instance == null) {
				instance = GameObject.FindObjectOfType<roadManager> ();
			}
			return instance;
		}
	}

	// Use this for initialization
	void Start () {

		CreateTiles (200);

		for (int i = 0; i < 50; i++) {
			SpawnTile ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnTile(){

		if (roads.Count == 0) {

			CreateTiles (10);
		}


		GameObject temp = roads.Pop ();
		temp.SetActive (true);
		temp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(1).position;
		currentTile = temp;

		int spawnBottle = Random.Range (0, 2);

		int bottleSelect = Random.Range (1, 4);

		if (spawnBottle == 0) {

			currentTile.transform.GetChild (bottleSelect).gameObject.SetActive (true);

		}

		int spawnCade = Random.Range (0, 4);
		int spawnCade1 = Random.Range (0, 4);
		int spawnCade2= Random.Range (0, 4);
		int spawnCade3 = Random.Range (0, 4);

		//int barricadeSelectOne = Random.Range (0, 1);
		//int randomZOne = Random.Range (-40, 40);
		//int barricadeSelectTwo = Random.Range(2,3);
		//int randomZTwo = Random.Range (-40, 40);

		if (spawnCade == 0) {

			currentTile.transform.GetChild (5).transform.GetChild (0).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCade1 == 0) {

			currentTile.transform.GetChild (5).transform.GetChild (1).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCade2 == 0) {

			currentTile.transform.GetChild (5).transform.GetChild (2).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCade3 == 0) {

			currentTile.transform.GetChild (5).transform.GetChild (3).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		/*

		currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).gameObject.SetActive (true);
		GameObject barr1 = currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).gameObject;
		barr1.transform.position = new Vector3 (barr1.transform.position.x, 1, randomZOne);

		currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectTwo).gameObject.SetActive (true);
		GameObject barr2 = currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectTwo).gameObject;
		barr2.transform.position = new Vector3 (barr2.transform.position.x, 1, randomZTwo);*/


		int spawnTrash = Random.Range (0, 3);
		int spawnTrash1 = Random.Range (0, 3);
		int spawnTrash2= Random.Range (0, 3);
		int spawnTrash3 = Random.Range (0, 3);


		if (spawnTrash == 0) {

			currentTile.transform.GetChild (6).transform.GetChild (0).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnTrash1 == 0) {

			currentTile.transform.GetChild (6).transform.GetChild (1).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnTrash2 == 0) {

			currentTile.transform.GetChild (6).transform.GetChild (2).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnTrash3 == 0) {

			currentTile.transform.GetChild (6).transform.GetChild (3).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}


		int spawnCar = Random.Range (0, 1);
		int spawnCar1 = Random.Range (0, 1);

		if (spawnCar == 0) {

			currentTile.transform.GetChild (7).transform.GetChild (0).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCar1 == 0) {

			currentTile.transform.GetChild (7).transform.GetChild (1).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}

		int spawnBox = Random.Range (0, 1);
		int spawnBox1 = Random.Range (0, 1);
		int spawnBox2 = Random.Range (0, 1);
		int spawnBox3 = Random.Range (0, 1);

		if (spawnBox == 0) {

			currentTile.transform.GetChild (8).transform.GetChild (0).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnBox1 == 0) {

			currentTile.transform.GetChild (8).transform.GetChild (1).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnBox2 == 0) {

			currentTile.transform.GetChild (8).transform.GetChild (2).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnBox3 == 0) {

			currentTile.transform.GetChild (8).transform.GetChild (3).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}

		int spawnCone = Random.Range (0, 3);
		int spawnCone1 = Random.Range (0, 3);
		int spawnCone2 = Random.Range (0, 3);
		int spawnCone3 = Random.Range (0, 3);

		if (spawnCone == 0) {

			currentTile.transform.GetChild (9).transform.GetChild (0).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCone1 == 0) {

			currentTile.transform.GetChild (9).transform.GetChild (1).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCone2 == 0) {

			currentTile.transform.GetChild (9).transform.GetChild (2).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}
		if (spawnCone3 == 0) {

			currentTile.transform.GetChild (9).transform.GetChild (3).gameObject.SetActive (true);
			//currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position = new Vector3(currentTile.transform.GetChild (5).transform.GetChild (barricadeSelectOne).position.x, 1, barricadeSelectOne);

		}



	}

	public void CreateTiles(int amount){

		for (int i = 0; i < amount; i++) {

			roads.Push (Instantiate (nextTilePrefab));
			roads.Peek ().name = "NextTile";
			roads.Peek ().SetActive (false);
		}
			
	}
}
