using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExploreController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _an;
    private Vector2 movement;


    public float movementSpeed = 6;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _an = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    private void Move()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        _an.SetFloat("Horizontal", movement.x);
        _an.SetFloat("Vertical", movement.y);
        _an.SetFloat("Speed", movement.sqrMagnitude);
    }  
}
