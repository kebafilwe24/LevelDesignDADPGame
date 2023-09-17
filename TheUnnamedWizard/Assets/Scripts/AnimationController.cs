using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    [SerializeField] Animator animator;
    Vector3 move;

    bool setRun, setJump;

    enum playerMove
    {
        foward = 1,
        back = 2,
        idle = 0,
        left = 3,
        right = 4,
        fowardRun = 5,
        jump = 6,
        attack = 7,
    }
    // Start is called before the first frame update
    void Start()
    {
        setRun = setJump = false;
    }


    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        move.Normalize();

        if (Input.GetKey(KeyCode.LeftShift))
            setRun = true;
        else
            setRun = false;

        if (Input.GetKey(KeyCode.Space))
            setJump = true;
        else
            setJump = false;

        if (move.y != 0)
        {
            if (move.y > 0)
                if (setRun == true)
                    animator.SetInteger("playerMove", (int)playerMove.fowardRun);
                else
                    animator.SetInteger("playerMove", (int)playerMove.foward);

            else
                animator.SetInteger("playerMove", (int)playerMove.back);
        }

        else if (setJump == true)
            animator.SetInteger("playerMove", (int)playerMove.jump);

        else if (move == Vector3.zero)
            animator.SetInteger("playerMove", (int)playerMove.idle);

        if (Input.GetKey(KeyCode.Mouse0))
            animator.SetInteger("playerMove", (int)playerMove.attack);
    }
}
