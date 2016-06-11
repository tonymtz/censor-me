using UnityEngine;

public class EnemyController : MonoBehaviour {
    private Transform myTransform;
    private Animator myAnimator;

    // Use this for initialization
    void Start () {
        myTransform = GetComponent<Transform>();
        myAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (myTransform.position.y + myTransform.GetComponent<Renderer>().bounds.size.y < max.y)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collider) {
		// layer 11 - Bullet
		if (collider.gameObject.layer == 10) {
            Destroy(collider.gameObject);
            Die();
        }
	}

    void OnCollisionEnter2D(Collision2D collider)
    {
        // layer 12 - Bounds
        if (collider.gameObject.layer == 12)
        {
            Die();
        }
    }

    void Die() {
        myAnimator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;

        Rigidbody2D myRigidBody = GetComponent<Rigidbody2D>();
        myRigidBody.velocity = new Vector2(10f, 20f);

        CoinSpawner mySpawner = GetComponent<CoinSpawner>();

        if (mySpawner) {
            mySpawner.Spawn(myRigidBody.position.x, myRigidBody.position.y, 1f);
        }
    }
}
