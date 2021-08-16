using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public static float speed;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public LayerMask woda;
    public float jumpHeight = 3f;
    Vector3 velocity;
    bool isGrounded;
    bool isWoda;
    public static Camera cam;
    public Transform miejscedotp;

    void Start(){
        cam = Camera.main;
    }
   
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isWoda = Physics.CheckSphere(groundCheck.position, groundDistance, woda);
        if(isGrounded && velocity.y<0)
            velocity.y = -2f;

        if(isWoda)
            {
                controller.enabled = false;
                controller.transform.position = miejscedotp.transform.position;
                controller.enabled=true;
            }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if(ZMIANAKIERUNKU.x==1||ZMIANAKIERUNKU2.x==1)
        {
            z = Input.GetAxis("Horizontal");
            x = Input.GetAxis("Vertical");
        }
        if(ZMIANAKIERUNKU2.x==3)
        {
            z = Input.GetAxis("Horizontal");
            x = Input.GetAxis("Vertical");
        }
        if(!TURBO.x){
        if(Input.GetKey(KeyCode.LeftShift))
            speed = 12;
        else if(Input.GetKey(KeyCode.T))
            speed = 24;
        else speed = 6;}else speed = 48;
        Vector3 move = transform.right * x + transform.forward * z;
        
        if(ZMIANAKIERUNKU2.x==2)
        {
        move = transform.right * x*-1 + transform.forward * z*-1;
        }
       if(ZMIANAKIERUNKU2.x==3){
             move = transform.right * x + transform.forward * z*-1;    
        }
        if(ZMIANAKIERUNKU2.x==4){
             move = transform.right * x*-1 + transform.forward * z;
        }

        controller.Move(move*speed*Time.deltaTime);

        
        /*
        if(Input.GetKeyDown("e")){
            //cam.fieldOfView++;
            jumpHeight+=5;
        }
        if(Input.GetKeyDown("q")){
            //cam.fieldOfView++;
            jumpHeight-=5;
        }*/
        
        
        if(Input.GetButtonDown("Jump") && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight* -2f * gravity);
        velocity.y+= gravity*Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);




    }
}
