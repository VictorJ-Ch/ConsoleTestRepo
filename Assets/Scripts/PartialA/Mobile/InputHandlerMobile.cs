using UnityEngine;
using UnityEngine.UIElements;

public class InputHandlerMobile : MonoBehaviour
{
    public delegate void MoveLeft();
    public MoveLeft moveLeft;

    public delegate void MoveRight();
    public MoveRight moveRight;

    void Start()
    {
        KeyboardMovement();
    }

    void Update()
    {
        //Keyboard
        float playerMovement = Input.GetAxis("Horizontal");
        if (playerMovement < 0) { moveLeft?.Invoke(); }
        else if (playerMovement > 0) { moveRight?.Invoke(); }

        //Touch
        if (Input.touchCount > 0)
        {
            Touch firstTouch = Input.GetTouch(0);

            if (firstTouch.position.x < Screen.width / 2)
            {
                Debug.Log("Mitad Left");
                moveLeft?.Invoke();
            }

            if (firstTouch.position.x > Screen.width / 2)
            {
                Debug.Log("Mitad Right");
                moveRight?.Invoke();
            }
        }
    }

    public void KeyboardMovement()
    { 
        float playerMovement = Input.GetAxis("Horizontal");
    }
}
