using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    [Header("Controls")]
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
    }

    void Update()
    {
        movement = Vector2.zero;

        if (Input.GetKey(upKey)) movement.y += 1f;
        if (Input.GetKey(downKey)) movement.y -= 1f;
        if (Input.GetKey(leftKey)) movement.x -= 1f;
        if (Input.GetKey(rightKey)) movement.x += 1f;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * moveSpeed;
    }
}
