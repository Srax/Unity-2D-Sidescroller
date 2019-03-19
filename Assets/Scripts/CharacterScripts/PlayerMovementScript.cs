using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;

    public float walkSpeed = 20f;
    public float runSpeed = 40f;

    float moveSpeed;

    bool jump = false;
    public bool isRunning = false;


    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("playerSpeed", Mathf.Abs(horizontalMove));

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if(isRunning == true){moveSpeed = runSpeed;}
        if(isRunning == false){moveSpeed = walkSpeed;}
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public IEnumerator SpeedUp(float time)
    {
        isRunning = true;
        yield return new WaitForSeconds(time);
        isRunning = false;
    }

}
