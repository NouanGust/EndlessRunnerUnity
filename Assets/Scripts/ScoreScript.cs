using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public TMP_Text scoreText;
    public int score;

    public void SaveScore(){
        PlayerPrefs.SetInt("ScoreFinal", score);
        PlayerPrefs.Save();
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("obstacle")){
            score ++;
            scoreText.text = "Score: " + score;
        }
    }
}
