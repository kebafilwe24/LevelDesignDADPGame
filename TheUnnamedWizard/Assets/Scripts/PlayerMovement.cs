using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float characterSpeed;
    [SerializeField] float runSpeed;
    Vector3 playerMove;

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

    private void FixedUpdate()
    {
        playerMove.x = Input.GetAxis("Horizontal");
        playerMove.z = Input.GetAxis("Vertical");

        playerMove.Normalize();

        this.gameObject.GetComponent<Rigidbody>().velocity = playerMove * characterSpeed ;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
