using UnityEngine;

public class GameController : Timer {
    [SerializeField]
    private float gameSpeedDelay = 5f;
    [SerializeField]
    private float gameSpeedStep = 2f;

    private float gameSpeed;
    public bool hasGameStarted { get; set; }
    public bool isGameOver { get; set; }

    // Use this for initialization
    override public void Start() {
        gameSpeed = 1;
        timeOut = gameSpeedDelay;
        timeLeft = timeOut;
        // TMP
        hasGameStarted = true;
    }

    public override void Callback() {
        Debug.Log("CALLABCK");
        gameSpeed += gameSpeedStep;
    }

    public override bool DoCycle() {
        return hasGameStarted;
    }

    public float GameSpeed() {
        return gameSpeed;
    }
}
