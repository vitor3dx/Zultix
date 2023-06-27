using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//modified for 3ds
public class PlayerMovement : MonoBehaviour
{
    public float MovementSpeed = 2;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    private AudioSource _audioSource;
    public Animator animator;

    public SpriteRenderer spriteRenderer;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        animator.SetFloat("speed", Mathf.Abs(movement));

        if(movement > 0){
            spriteRenderer.flipX = false;
        }else if(movement < 0){
            spriteRenderer.flipX = true;
        }
        
        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            _audioSource.Play();
        }
    }
}