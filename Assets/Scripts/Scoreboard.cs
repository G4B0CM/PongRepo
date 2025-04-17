using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI player1Text;
    [SerializeField] TextMeshProUGUI player2Text;
    [SerializeField] TextMeshProUGUI winText;

    private int player1Score = 0;
    private int player2Score = 0;

    public void IncreaseScorePlayer1(int points)
    {
        player1Score += points;
        player1Text.text = player1Score.ToString();
        if (player1Score == 5) {
            Destroy(this.gameObject);
            winText.text = "Ganó el Jugador 1";
        }

    }

    public void IncreaseScorePlayer2(int points)
    {
        player2Score += points;
        player2Text.text = player2Score.ToString();
        if (player2Score == 5)
        {
            Destroy(this.gameObject);
            winText.text = "Ganó el Jugador 2";
        }
    }

}
