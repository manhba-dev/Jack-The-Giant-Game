﻿using UnityEngine;
using System.Collections;

public class CollectableScript : MonoBehaviour {

	void OnEnable(){
		Invoke ("DestroyCollectable",1f);
	}

	void DestroyCollectable(){
		gameObject.SetActive (false);
	}
}
