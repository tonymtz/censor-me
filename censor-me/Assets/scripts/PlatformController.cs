using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

		if (myTransform.position.x + myTransform.GetComponent<Renderer> ().bounds.size.x < min.x) {
			Destroy (gameObject);
		}
	}
}
