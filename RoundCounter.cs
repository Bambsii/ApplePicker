using UnityEngine;
using TMPro;

public class RoundManager : MonoBehaviour
{
    public TextMeshProUGUI roundText; 
    private int currentRound = 1;
    private int pointsPerRound = 1000; 

    private ScoreCounter scoreCounter;

    void Start()
    {
        scoreCounter = FindObjectOfType<ScoreCounter>(); 
        UpdateRoundText();
    }

    void Update()
    {
       
        if (scoreCounter.score >= currentRound * pointsPerRound)
        {
            currentRound++;
            UpdateRoundText();
        }
    }

    void UpdateRoundText()
    {
        roundText.text = "Round " + currentRound;
    }
}

