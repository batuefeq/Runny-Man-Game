using UnityEngine;

// this is level handler. it kills object that falls far away from player.
public class LevelHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public Transform endPointTransform;


    public delegate void MapSpawn();
    public event MapSpawn OnMapSpawn;



    private void FollowPlayer()
    {
        transform.position = player.transform.position;
    }


    private void OnTriggerExit(Collider other)
    {
        print("name of the gameobjcet : " + other.gameObject);

        if (other.CompareTag("EndPoint"))
        {

        }
        else
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("EndPoint"))
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndPoint"))
        {

            endPointTransform = other.transform;
        }
    }


    private void Update()
    {
        FollowPlayer();
    }
}