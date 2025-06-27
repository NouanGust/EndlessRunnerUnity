using UnityEngine;

public class backgroundScrolling : MonoBehaviour {
    
    public float addicionalScrollSpeed;

    public GameObject[] backgrounds;

    public float[] scrollSpeed;


    private void FixedUpdate(){
        for (int background = 0; background < backgrounds.Length; background ++) {

            Renderer rend = backgrounds[background].GetComponent<Renderer>();
            float offset = Time.time *(scrollSpeed[background] + addicionalScrollSpeed);

            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        }
    }


}
