﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

	public float ScrollX = 0;
	public float ScrollY = 0.5f;
	// Update is called once per frame
	void Update () {
		float OffsetX = Time.time * ScrollX;
		float OffsetY = Time.time * ScrollY;
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (OffsetX, OffsetY);
	}
}
