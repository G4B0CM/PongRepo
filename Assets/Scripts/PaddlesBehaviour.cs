using UnityEngine;

public class PaddlesBehaviour : MonoBehaviour
{
    [SerializeField] private KeyCode upKey = KeyCode.W;
    [SerializeField] private KeyCode downKey = KeyCode.S;
    [SerializeField] private float speed = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(upKey))
            move = 1f;
        else if (Input.GetKey(downKey))
            move = -1f;

        rb.linearVelocity = new Vector2(0, move * speed);
    }
    
}
