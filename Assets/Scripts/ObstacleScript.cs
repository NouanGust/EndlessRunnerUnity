using UnityEngine;
using TMPro;

public class ObstacleScript : MonoBehaviour {

    public GeneratorScript GeneratorScript;


    void Update() {
       transform.Translate(Vector2.left * GeneratorScript.CurrentSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision) {
        
        if(collision.gameObject.CompareTag("nextline")) {
           GeneratorScript.generateObtacle(); 
        }

        if(collision.gameObject.CompareTag("finishline")) {
           Destroy(this.gameObject);
        }
    }
}
