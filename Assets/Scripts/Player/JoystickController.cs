using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class JoystickController : MonoBehaviour
{

    [SerializeField]private Transform playerTransform;
    public GameObject[] playerSprites;
    [SerializeField]private float moveSpeed = 5f;
    public Transform player;
    [SerializeField]private Camera mainCamera;
    [SerializeField]private Vector2 screenBounds;
    [SerializeField] private InputActionReference mooveAction;

  void Start()
    {
        mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }
    void Update()
    {

        Vector2 moveDirection= mooveAction.action.ReadValue<Vector2>();
        transform.Translate(moveDirection*moveSpeed*Time.deltaTime);
        if (moveDirection.x < 0)
        {

            RotateSpritesLeft(); // Flip sprite horizontally
            
        }
        else if (moveDirection.x > 0)
        {
            RotateSpritesRight(); // Reset sprite scale
            
        }
    }
    void RotateSpritesLeft()
    {
        foreach (GameObject obj in playerSprites)
        {
            obj.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    void RotateSpritesRight()
    {
        foreach (GameObject obj in playerSprites)
        {
            obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
