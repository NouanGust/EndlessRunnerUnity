using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SaveScript: MonoBehaviour{
    
    public void SaveData(int score){
        PlayerPrefs.SetInt("ScoreFinal", score);
        PlayerPrefs.Save();
    }

    public void LoadData(){
        PlayerPrefs.GetInt("Score");
    }
}
