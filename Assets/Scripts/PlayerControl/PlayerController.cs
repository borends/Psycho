using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    public float jumpForce;
    public float speed;
    private float _fallVelocity = 0f;
    private Vector3 _moveVector;
    private CharacterController _characterController;
    public Animator animator;

    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        _moveVector = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("InMotionF", true);
            _moveVector += transform.forward;
        }
        else
        {
            animator.SetBool("InMotionF", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("InMotionL", true);
            _moveVector -= transform.right;
        }
        else
        {
            animator.SetBool("InMotionL", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("InMotionB", true);
            _moveVector -= transform.forward;
        }
        else
        {
            animator.SetBool("InMotionB", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("InMotionR", true);
            _moveVector += transform.right;
        }
        else
        {
            animator.SetBool("InMotionR", false);
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            animator.SetBool("InMotionF", false);
            animator.SetBool("InMotionB", false);
            animator.SetBool("InMotionL", false);
            animator.SetBool("InMotionR", false);
        }



        if (Input.GetKeyDown(KeyCode.Space) && _characterController.isGrounded)
        {
            _fallVelocity = -jumpForce;
        }
    }

    void FixedUpdate()
    {
        _characterController.Move(_moveVector * speed * Time.fixedDeltaTime);
        _fallVelocity += gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }
}
