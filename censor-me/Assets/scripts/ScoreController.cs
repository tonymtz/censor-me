using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {
    [SerializeField]
    private PlayerController player;

    private Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText = GetComponent<Text>();
	}
	
	void LateUpdate () {
        scoreText.text = player.GetCoins().ToString();
	}
}
