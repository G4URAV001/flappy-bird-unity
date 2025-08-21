using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created}
    public Text scoreText;
    public int playerScore;

    [ContextMenu("increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

}

