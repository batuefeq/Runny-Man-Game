using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    private float x_input;
    private CharacterController controller;

    [SerializeField]
    private float mouseSens;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        MovingHandle();
        InputHandle();
    }


    private void InputHandle()
    {
        x_input = Input.GetAxis("Horizontal");
    }


    private void MovingHandle()
    {
        controller.Move(new Vector3(x_input, 0, 0) * Time.deltaTime * mouseSens);
    }
}