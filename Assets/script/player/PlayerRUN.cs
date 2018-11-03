﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRUN : PlayerFSMState 
{
	public Transform marker;
	public float moveSpeed = 3.0f;

	// Use this for initialization
	void Start () {
		marker = GameObject.FindGameObjectWithTag("Marker").transform;		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(
			transform.position,
			marker.position,
			moveSpeed * Time.deltaTime);
	}
}
