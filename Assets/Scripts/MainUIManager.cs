using TMPro;
using UnityEngine;

public class MainUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text player1Score;
    [SerializeField] private TMP_Text player2Score;

    private void Awake()
    {
        player1Score.text = player2Score.text = 0.ToString();
    }
}
