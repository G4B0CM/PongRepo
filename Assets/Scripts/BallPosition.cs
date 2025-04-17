using UnityEngine;

public class BallPosition : MonoBehaviour
{
    [SerializeField] private float startSpeed = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("LaunchBall",1f);
    }

    
    void LaunchBall()
    {
        
        float xDirection = Random.value < 0.5f ? -1f : 1f;
        float yDirection = Random.Range(-0.5f, 0.5f);

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;
        rb.linearVelocity = direction * startSpeed;
    }

    
    public void ResetBall()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke(nameof(LaunchBall), 1f); 
    }


}
