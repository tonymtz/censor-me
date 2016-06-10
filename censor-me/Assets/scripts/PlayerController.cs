using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private bool isGrounded;
    [SerializeField]
    private LayerMask whatIsGround;

    private Rigidbody2D myRigidBody;
    private Collider2D myCollider;

    // Use this for initialization
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        myRigidBody.velocity = new Vector2(moveSpeed, myRigidBody.velocity.y);

        // Jump
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButtonDown(0)) && isGrounded)
        {
            myRigidBody.velocity = new Vector2(myRigidBody.velocity.x, jumpForce);
        }

        // Shoot
        if (Input.GetKeyDown(KeyCode.M) || Input.GetMouseButtonDown(1)) { }
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
    }
}
