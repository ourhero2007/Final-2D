using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _kickLeft;
    [SerializeField] private GameObject _kickRight;
    [SerializeField] private GameController _gameController;

    // Add member variables to store references to this GameObject's 
    //      Rigidbody, Animator, and SpriteRenderer.
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    [SerializeField] private float _speed;
    [SerializeField] private float _jump;

    private bool _facingLeft;
    private bool _isGrounded = true;

    // ------------------------------------------------------------------------
    // Add a built-in UNITY METHOD that runs EVERY FRAME.
    // Detect input to move player left/right, jump, and kick
    // Change character facing with SpriteRenderer.flipX value
    // Set animation parameters 

    private void Update()
    {
        _rigidbody.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * _speed, _rigidbody.linearVelocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            _isGrounded = false;
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _jump);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Kick();
        }

    }

    // ------------------------------------------------------------------------
    private void Kick()
    {
        // Set animation parameter.

        // Either activate left or right kick based on character facing
    }

    // ------------------------------------------------------------------------
    // Use a built-in Unity method to detect COLLISION.
    // Use this to avoid allowing the Player to double jump- they should
    //      collide with an object with the Ground tag before being able to
    //      jump again.

    private void OnCollisionEnter2D(Collision2D collision)
    {


    }

}
