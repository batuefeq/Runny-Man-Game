using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.TouchPhase;

public class PlayerHandler : MonoBehaviour
{
    private float x_input;
    private CharacterController controller;

    [SerializeField]
    private float playerSpeed;



    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        InputAndMovementHandle();
    }


    public void OnMovement(InputAction.CallbackContext value)
    {
        float inputMovement = value.ReadValue<Vector2>().x;
        x_input = inputMovement;
        print(x_input);
    }


    private void InputAndMovementHandle()
    {

        foreach (Touch touch in Input.touches)  // take touches
        {
            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) // if touch just began
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position); // took the ray and maybe do smthn !
                if (touch.position.x <= Screen.width / 2)
                {
                    controller.Move(Vector3.left * Time.deltaTime * playerSpeed); // if left side of the screen move to left
                }
                else
                {
                    controller.Move(Vector3.right * Time.deltaTime * playerSpeed); // otherwise move to right !
                }

            }
        }
        controller.Move(new Vector3(x_input, 0, 0) * Time.deltaTime * playerSpeed);
    }





}