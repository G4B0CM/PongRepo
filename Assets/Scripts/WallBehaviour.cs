using System.Collections;
using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    Scoreboard scoreboard;
    [SerializeField] int valorPuntos = 1;

    private void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entre");
        if (collision.gameObject.tag == "Player" && this.tag == "Wall1")
        {
            scoreboard.IncreaseScorePlayer2(valorPuntos);
            collision.gameObject.transform.position = new Vector2(0, 0);
        }
        else if(collision.gameObject.tag == "Player" && this.tag == "Wall2")
        {
            scoreboard.IncreaseScorePlayer1(valorPuntos);
            collision.gameObject.transform.position = new Vector2(0, 0);
        }

    }

   
}
