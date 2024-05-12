using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;
    [SerializeField] private SpriteRenderer characterRenderer;
    protected Animator animator;
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private readonly float magnituteThreshold = 0.5f;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }
    void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
        animator.SetBool(IsWalking, direction.magnitude > magnituteThreshold);

    }

    private void ApplyMovement(Vector2 direction) 
    {
        direction = direction * 5; 

        movementRigidbody.velocity = direction;
    
        characterRenderer.flipX = direction.x < 0;
    }
}
