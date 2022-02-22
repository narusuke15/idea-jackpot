using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]

//ASSIGN TO CANVAS TO AUTO SEEKING MAIN CAMERA
public class CanvasAutoSeekingCamera : MonoBehaviour {

	void Awake () {
		var canvas = GetComponent<Canvas>();
		canvas.worldCamera = Camera.main;
	}
	
}
