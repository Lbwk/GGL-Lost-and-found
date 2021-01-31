using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed == 2;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    void FixeUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
}
