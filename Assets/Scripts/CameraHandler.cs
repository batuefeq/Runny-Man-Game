using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject camPlaceSlow, camPlaceNorm, camPlaceFast;

    private readonly float slowSpeed = 20;
    private readonly float fastSpeed = 100;

    private float lerpTime = 0.2f;

    private void CameraSpeedHandler()
    {
        if (GetComponentInParent<PlayerHandler>().PlayerSpeed <= slowSpeed)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.parent.position.x, lerpTime), Mathf.Lerp(transform.position.y, camPlaceSlow.transform.position.y, lerpTime), Mathf.Lerp(transform.position.z, camPlaceSlow.transform.position.z, lerpTime));
        }
        else if (GetComponentInParent<PlayerHandler>().PlayerSpeed > slowSpeed && GetComponentInParent<PlayerHandler>().PlayerSpeed < fastSpeed)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.parent.position.x, lerpTime), Mathf.Lerp(transform.position.y, camPlaceNorm.transform.position.y, lerpTime), Mathf.Lerp(transform.position.z, camPlaceNorm.transform.position.z, lerpTime));
        }
        else if (GetComponentInParent<PlayerHandler>().PlayerSpeed >= fastSpeed)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, transform.parent.position.x, lerpTime), Mathf.Lerp(transform.position.y, camPlaceFast.transform.position.y, lerpTime), Mathf.Lerp(transform.position.z, camPlaceFast.transform.position.z, lerpTime));
        }
    }


    void Update()
    {
        CameraSpeedHandler();
    }
}
