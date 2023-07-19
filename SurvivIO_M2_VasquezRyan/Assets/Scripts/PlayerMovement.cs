using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Unit
{
    public Joystick leftJoyStick;
    public Joystick rightJoyStick;

    Vector2 move;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float _moveSpeed;

    protected override void Shoot()
    {
        base.Shoot();
        Debug.Log($"{_name} is shooting");
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        move.x = leftJoyStick.Horizontal;
        move.y = leftJoyStick.Vertical;

        Vector3 moveVector = (Vector3.up * rightJoyStick.Horizontal + Vector3.left * rightJoyStick.Vertical);
        if (rightJoyStick.Horizontal != 0 || rightJoyStick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            Shoot();
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * _moveSpeed * Time.fixedDeltaTime);
    }
}
