using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExploreController : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float movementSpeed = 6;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.velocity = new Vector2(movementSpeed, _rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.velocity = new Vector2(-movementSpeed, _rb.velocity.y);
        }
        else
        {
            _rb.velocity = new Vector2(0, _rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, movementSpeed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, -movementSpeed);
        }
        else
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }
    }
}
