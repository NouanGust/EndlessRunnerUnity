using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

    public void ComecarJogo(){
        SceneManager.LoadSceneAsync("CenaPrincipal");
    }

    public void SairJogo() {
        Application.Quit();
    }

}
