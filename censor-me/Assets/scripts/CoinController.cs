using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collider)
    {
        // layer 12 - Bounds
        if (collider.gameObject.layer == 12)
        {
            Destroy(gameObject);
        }
    }
}
