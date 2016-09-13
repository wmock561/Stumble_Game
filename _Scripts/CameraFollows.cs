﻿using UnityEngine;
using System.Collections;


public class CameraFollows : MonoBehaviour
{

	public float cameraDistOffset = 10;
	private Camera mainCamera;
	private GameObject player;

	// Use this for initialization
	void Start () {
		mainCamera = GetComponent<Camera>();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
		Vector3 playerInfo = player.transform.transform.position;

		mainCamera.transform.position = new Vector3(mainCamera.transform.position.x, mainCamera.transform.position.y, playerInfo.z - cameraDistOffset);
	}
}