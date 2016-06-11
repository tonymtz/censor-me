using UnityEngine;
using System.Collections;

public class EnemyHornSkullController : Timer {
    [SerializeField]
    private float turnDelay;
    [SerializeField]
    private float moveSpeed;

    private bool isGoingLeft;
    private Rigidbody2D myRigidBody;

    // Use this for initialization
    public override void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        timeOut = turnDelay;
        base.Start();
    }

    public override void Callback()
    {
        Turn();
    }

    void Turn()
    {
        int multiplier = isGoingLeft ? 1 : -1;

        isGoingLeft = !isGoingLeft;
        myRigidBody.velocity = new Vector2(moveSpeed * multiplier, myRigidBody.velocity.y);
    }
}
