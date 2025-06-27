using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    [Header ("UI")]
    public Scene startScreen;
    public Scene gameOverScreen;
    public TMP_Text scoreText;
    public TMP_Text StartScreen;

    [Header ("Jogo")]
    public bool isGameActive = false;
    public int score = 0;
    public bool isPlayerAlive = true;
    public bool isPaused = false;


    void Awake(){
        if(instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Start(){
        SceneManager.LoadScene("CenaPrincipal");
    }


    void Update(){
        if(isGameActive && isPlayerAlive){

        }
    }

    public void StartGame(){
        SceneManager.LoadScene("CenaPrincipal");
    }


    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }
}
