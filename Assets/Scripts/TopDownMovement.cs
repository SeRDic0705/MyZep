using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController controller;
    private Rigidbody2D rigidbody2D;

    private Vector2 movementDirection = Vector2.zero;

    public float speed = 5;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= speed;

        rigidbody2D.velocity = direction;
    }
}
