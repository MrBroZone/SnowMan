using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float hori = 0f;
    public float sped = 40f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal") * sped;

        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
        if(Input.GetButtonDown("Crouch")){
            crouch = true;
        }
        else if(Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }
    void FixedUpdate(){
        controller.Move(hori * Time.fixedDeltaTime ,crouch,jump);
        jump = false;
        
    }
}
