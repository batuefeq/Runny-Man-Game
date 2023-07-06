using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField]
    private GainScriptableObject speedOptions;

    private PlayerHandler playerHandler;

    void Awake()
    {
        playerHandler = GetComponent<PlayerHandler>();
    }


    private void AutoMove()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerHandler.PlayerSpeed = speedOptions.enemySpeedGain;
        }
        else if (other.CompareTag("Obstacle"))
        {
            playerHandler.PlayerSpeed = speedOptions.obstacleSpeedGain;
        }
    }


    void Update()
    {
        AutoMove();
    }
}
