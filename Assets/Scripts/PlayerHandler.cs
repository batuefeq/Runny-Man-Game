using UnityEngine;

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


    private void InputAndMovementHandle()
    {
        if (DeviceTypeHandler.TypeFinder()) // on mobile device!
        {
            print("yes this is");
            foreach (Touch touch in Input.touches)  // take touches
            {
                if (touch.phase == TouchPhase.Began) // if touch just began
                {
                    Ray ray = Camera.main.ScreenPointToRay(touch.position); // took the ray whether do smthn !
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
        }
        else // if not mobile device!
        {
            
            x_input = Input.GetAxis("Horizontal"); // interpolating through keyboard to make it smooth.(why getaxis?)
            controller.Move(new Vector3(x_input, 0, 0) * Time.deltaTime * playerSpeed);
            print("yes this is");
            foreach (Touch touch in Input.touches)  // take touches
            {
                if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary) // if touch just began
                {
                    Ray ray = Camera.main.ScreenPointToRay(touch.position); // took the ray whether do smthn !
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
        }     
    }
}