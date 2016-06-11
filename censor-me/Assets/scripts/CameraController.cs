using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	[SerializeField]
	private Transform target;

	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
	}

	void LateUpdate()
	{
		float offset = 20f; // hardcoded lol
		myTransform.position = new Vector2 (target.position.x + offset, myTransform.position.y);
	}
}
