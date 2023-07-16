using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // in this script i adjust the speed of the player according to the actions of the player.

    [SerializeField]
    private GainScriptableObject speedOptions;

    private PlayerHandler playerHandler;

    void Awake()
    {
        playerHandler = GetComponent<PlayerHandler>();
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


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            playerHandler.PlayerSpeed = speedOptions.enemySpeedLose;
            Destroy(hit.gameObject);
        }
        else if (hit.gameObject.CompareTag("Obstacle"))
        {
            playerHandler.PlayerSpeed = speedOptions.obstacleSpeedLose;
            Destroy(hit.gameObject);
        }
    }


    void Update()
    {

    }
}