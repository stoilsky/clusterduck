﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZSetter : MonoBehaviour {
	void Update() {
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
	}
}
