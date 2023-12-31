using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.TouchPhase;

public class PlayerHandler : MonoBehaviour
{
    private float x_input;
    private CharacterController controller;

    [SerializeField]
    private float sensitivity;


    private int playerSpeed;
    public int PlayerSpeed
    {
        get
        {
            if (playerSpeed >= 0)
            {
                return playerSpeed;
            }
            else
            {
                return 0;
            }            
        }
        set
        {
            if (playerSpeed >= 0)
            {
                playerSpeed += value;
            }         
        }
    }


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        PlayerSpeed = 5;
    }


    public void OnMovement(InputAction.CallbackContext value)
    {
        float inputMovement = value.ReadValue<Vector2>().x;
        x_input = inputMovement;
        print(x_input);
    }


    private void MobileMovementHandle()
    {

        foreach (Touch touch in Input.touches)  // take touches
        {
            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) // if touch just began
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position); // took the ray and maybe do smthn !
                if (touch.position.x <= Screen.width / 2)
                {
                    controller.Move(new Vector3(Vector3.left.x * sensitivity, 0, playerSpeed) * Time.deltaTime); // if left side of the screen move to left
                    print("left");
                }
                else
                {
                    controller.Move(new Vector3(Vector3.right.x * sensitivity, 0, playerSpeed) * Time.deltaTime); // otherwise move to right !
                    print("right");
                }
            }
        }

        controller.Move(new Vector3(x_input * sensitivity, 0, playerSpeed) * Time.deltaTime);
    }


    void Update()
    {
        MobileMovementHandle();
    }
}