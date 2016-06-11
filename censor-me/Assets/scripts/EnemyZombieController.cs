using UnityEngine;
using System.Collections;

public class EnemyZombieController : MonoBehaviour {
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce = 40f;

    private Rigidbody2D myRigidBody;
    private bool canJump;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump)
        {
            canJump = false;
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        // layer 8 - Ground
        if (collider.gameObject.layer == 8)
        {
            canJump = true;
        }
    }
}
