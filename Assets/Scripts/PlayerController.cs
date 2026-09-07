using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    //Movement tuning (editable Inspactor)
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed;
    // Input System action exposed in Inspactor For Binding (WASD/Arrow Key)
    public InputAction moveAction;
    // Curren Input Value (X = Left/Right Y = Forwand/Backwand), Kept Private For Internal Use
    private Vector2 moveInput;

    public Camera mainCamera;
    public Camera camera2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable The MoveAction So It Starts Reading Input
        moveAction.Enable();
        mainCamera.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Read the 2D vector for the MoveAction (x : Horizontal, y : Vertical )
        moveInput = moveAction.ReadValue<Vector2>();

        //Move forward/back along local z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        // Rotate around local y (yaw) using the x component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (mainCamera.enabled == true)
            {
                mainCamera.enabled = !mainCamera.enabled;
                camera2.enabled = !camera2.enabled;
            }
            else
            {
                mainCamera.enabled = !mainCamera.enabled;
                camera2.enabled = !camera2.enabled;
            }
            
        }
    }
  
}
