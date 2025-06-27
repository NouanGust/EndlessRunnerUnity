using UnityEngine;

public class GeneratorScript : MonoBehaviour {

    public GameObject[] obstacles;

    public float MinSpeed;
    public float MaxSpeed;
    public float CurrentSpeed;
    public float SpeedMulti;

    void Awake() {
        CurrentSpeed = MinSpeed;
        generateObtacle();
    }

    public void generateObtacle() {
        GameObject obstacleToGenerate = obstacles[Random.Range(0, obstacles.Length)];
        GameObject obstacleIns = Instantiate(obstacleToGenerate, transform.position, transform.rotation);

        obstacleIns.GetComponent<ObstacleScript>().GeneratorScript = this;

    }



    void Update() {
        if(CurrentSpeed < MaxSpeed) {
            CurrentSpeed += SpeedMulti;
        }
    }
}
