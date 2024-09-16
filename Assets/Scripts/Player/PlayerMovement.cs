using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
=======
>>>>>>> asset

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D player;
<<<<<<< HEAD
    public float jumpForce;
    public float moveSpeed;
    public float direction;
    public float jumpCooldown; 
    private bool canJump = true;
    private bool moveLeft, moveRight;
    public bool crouch;

    public Animator animator;
=======
    public float jumpForce = 5f;
    public float moveSpeed = 100;
    public float direction;
    private bool moveLeft, moveRight;
>>>>>>> asset

    //inputSystem script
    PlayerControls controls;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Player.Move.performed += info =>
        {
            direction = info.ReadValue<float>();
        };
    }

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        player.velocity = new Vector2(direction * moveSpeed * Time.deltaTime, player.velocity.y);
<<<<<<< HEAD

=======
        
>>>>>>> asset
        if (moveLeft)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        if (moveRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

<<<<<<< HEAD
        if (Mathf.Abs(player.velocity.y) < 0.1f)
        {
            canJump = true;
        }
=======
>>>>>>> asset
    }

    public void JumpInput()
    {
<<<<<<< HEAD
        if (canJump && Mathf.Abs(player.velocity.y) < 0.1f) // Pastikan kecepatan vertikal mendekati nol
        {
            player.velocity = new Vector2(player.velocity.x, jumpForce);
            StartCoroutine(JumpCooldown());
        }
    }

    IEnumerator JumpCooldown()
    {
        canJump = false;
        yield return new WaitForSeconds(jumpCooldown);
        canJump = true; // Atur kembali menjadi true setelah cooldown selesai
    }

    public void CrouchInputButtonDown()
    {
        crouch = true;
    }

    public void CrouchInputButtonUp()
    {
        crouch = false;
=======
        player.velocity = new Vector2(player.velocity.x, jumpForce);
>>>>>>> asset
    }

    public void LeftInputButtonDown()
    {
        //kiri
        moveLeft = true;
        direction = -1;
    }

<<<<<<< HEAD
    public void LeftInputButtonUp()
=======
    public void LeftInputButtonUp() 
>>>>>>> asset
    {
        moveLeft = false;
    }

    public void RightInputButtonDown()
    {
        //kanan
        moveRight = true;
        direction = 1;
    }

<<<<<<< HEAD
    public void RightInputButtonUp()
    {
        moveRight = false;

    }
}
=======
    public void RightInputButtonUp() 
    {
        moveRight = false;
    
    }
}
>>>>>>> asset
