using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    private TopDownCharacterController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAim(Vector2 direction)
    {
        float rotZ = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
        spriteRenderer.flipX = Mathf.Abs (rotZ) > 90f;
    }
}
