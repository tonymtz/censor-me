using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	[SerializeField]
	private float speed;
	
	private Transform myTransform;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
	}

	void FixedUpdate () {
		myTransform.Translate (Vector2.right * speed * Time.deltaTime);

		Vector2 max = UnityEngine.Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

		if (myTransform.position.x > max.x) {
			Destroy (gameObject);
		}
	}
}
