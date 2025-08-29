using UnityEngine;

public class PlayerMovementManager : MonoBehaviour
{
    public InputHandlerMobile inputHandlerMobile;
    public GameObject playerSprite;
    public float playerSpeed;

    void OnEnable()
    {
        inputHandlerMobile.moveLeft += MoveLeft;
        inputHandlerMobile.moveRight += MoveRight;
    }

    void OnDisable()
    {
        inputHandlerMobile.moveLeft -= MoveLeft;
        inputHandlerMobile.moveRight -= MoveRight;
    }

    void MoveLeft() { playerSprite.transform.Translate(Vector3.left * playerSpeed * Time.deltaTime, Space.World); }

    void MoveRight() { playerSprite.transform.Translate(Vector3.right * playerSpeed * Time.deltaTime, Space.World); }
}
