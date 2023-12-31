﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

	private PlayerMoveJoystick playerMove;

	void Start(){
		playerMove = GameObject.Find ("Player").GetComponent<PlayerMoveJoystick> ();
	}

	public void OnPointerDown(PointerEventData data){
		if (gameObject.name == "Left") {
			playerMove.SetMoveLeft(true);
			//Debug.Log ("Touching The Left Button");

		} else {
			playerMove.SetMoveLeft(false);
			//Debug.Log("Touching The Right Button");
		}
	}

	public void OnPointerUp(PointerEventData data){
		playerMove.StopMoving ();
	}
}
	