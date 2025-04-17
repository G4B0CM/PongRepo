using System.Collections;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    Scoreboard scoreboard;
    BallPosition ball;
    [SerializeField] int valorPuntos = 1;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
        ball = FindFirstObjectByType<BallPosition>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entre");
        if (collision.gameObject.tag == "Player")
        {
            scoreboard.IncreaseScorePlayer2(valorPuntos);
            ball.IniciarPelota();
        }
        else if (collision.gameObject.tag == "Player")
        {
            scoreboard.IncreaseScorePlayer1(valorPuntos);
            ball.IniciarPelota();
        }
    }


}
