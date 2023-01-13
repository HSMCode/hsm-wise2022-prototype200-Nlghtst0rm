using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed;
    public float turnspeed;
    public Rigidbody rb;
    public float jumphight;
    public LayerMask GroundMask;
    public bool isGrounded;
    public Transform GroundCheck;
    public float GroundDistance;

    public Animator _playerAnim;


    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        turnspeed = 250;
        jumphight = 4;
        GroundDistance = 0.03f;

       _playerAnim = GetComponent<Animator>();
       
       
       
       //for jump
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
    
     //movement
     transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
     transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnspeed);

     //Jump
     if(Input.GetButton("Jump") && isGrounded)
     {
        rb.velocity = new Vector3(rb.velocity.x, jumphight, rb.velocity.z);
        
     }
        else
     {
       
     }
     
      //Groundcheck
        isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

     //Animation Run
     if(forwardInput > 0 || forwardInput < 0)
     {
        _playerAnim.SetBool("IsRunning", true);
     }
     else 
     {
        _playerAnim.SetBool("IsRunning", false);
     }
      if(isGrounded)
      {
          _playerAnim.SetBool("IsJumping", false);
          
      }
      else
      {
         _playerAnim.SetBool("IsJumping", true);
      }

    }
}
