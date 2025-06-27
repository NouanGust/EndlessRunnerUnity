using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenuScript : MonoBehaviour {

    public TMP_Text score;

    public void Start(){
        int scoreFinal = PlayerPrefs.GetInt("ScoreFinal");
        score.text = "Seu score final: " + scoreFinal;
    }

    public void Restart() {
        SceneManager.LoadSceneAsync("CenaPrincipal");
    }

    public void Sair() {
        SceneManager.LoadSceneAsync("MenuInicial");
    }
}
