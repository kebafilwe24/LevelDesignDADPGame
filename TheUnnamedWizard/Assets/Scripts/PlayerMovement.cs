using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float characterSpeed, runSpeed, rotationSpeed;
    [SerializeField] protected Transform cameraTransform;
    Vector3 playerMove, moveDirection;
    float setSpeed;
    bool enableRun = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Jump()
    {

    }

    void Run()
    {

    }

    void Attack()
    {

    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
            Cursor.lockState = CursorLockMode.Locked;
        else
            Cursor.lockState = CursorLockMode.None;
    }

    private void FixedUpdate()
    {

        if (enableRun)
            setSpeed = runSpeed;
        else
            setSpeed = characterSpeed;

        playerMove.x = Input.GetAxis("Horizontal");
        playerMove.z = Input.GetAxis("Vertical");


        playerMove.Normalize();

        playerMove = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * playerMove;

        this.gameObject.GetComponent<Rigidbody>().velocity = playerMove * setSpeed ;

        if (playerMove != Vector3.zero)
        {
            Quaternion characterRotation = Quaternion.LookRotation(playerMove, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation ,characterRotation, rotationSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            enableRun = true;
        else
            enableRun = false;
        
    }
}
