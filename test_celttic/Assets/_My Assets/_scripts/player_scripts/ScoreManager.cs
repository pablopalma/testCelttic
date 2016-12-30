using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

    public Text scoreTxt;
    private static int score;
	
	

	private void Update ()
    {
        scoreTxt.text = "Score: " + score;
	}

    public static int IncreaseScore(int _score)
    {
        score += _score;
        return score;
    }
}
