using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {
    [SerializeField]
    private int min = 1;
    [SerializeField]
    private int max = 3;
    [SerializeField]
    private GameObject baseCoin;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void Spawn() {
        Spawn(0f, 0f, 1f);
    }

    public void Spawn(float x, float y) {
        Spawn(x, y, 1f);
    }

    public void Spawn(float x, float y, float z) {
        int howMany = Random.Range(min, max + 1);

        while(howMany >= 0) {
            GameObject aCoin = (GameObject)Instantiate(baseCoin);
            aCoin.transform.position = new Vector3(x, y, z);
            Rigidbody2D coinRigidBody = aCoin.GetComponent<Rigidbody2D>();
            coinRigidBody.velocity = new Vector2(Random.Range(-10, 10), 20f);

            howMany--;
        }
    }
}
