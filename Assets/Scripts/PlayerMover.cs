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
        print(playerHandler.PlayerSpeed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerHandler.PlayerSpeed = speedOptions.enemySpeedGain;
            print(playerHandler.PlayerSpeed);
        }
        else if (other.CompareTag("Obstacle"))
        {
            playerHandler.PlayerSpeed = speedOptions.obstacleSpeedGain;
            print(playerHandler.PlayerSpeed);
        }
    }


    void Update()
    {
        AutoMove();
    }
}
