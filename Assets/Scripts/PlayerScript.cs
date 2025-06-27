using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public float jumpForce;
    [SerializeField] bool isGrounded = false;
    Rigidbody2D RB;
    private bool isAlive = true;
    // public TMP_Text ScoreText;
    float score;
    [SerializeField] Animator animator;

    AudioManagerScript audioManager;
    public ScoreScript scoreScript;


    void Awake()
    {
        // Pega uma referência do Rigidbody
        RB = GetComponent<Rigidbody2D>();
        // Seta o Score para 0
        score = 0;

        // Pega referência do AudioManager 
        audioManager = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioManagerScript>();
    }

    void Update()
    {

        // Pula -- Aqui pega o input do Espaço e aplica uma força para cima.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                audioManager.PlaySFX(audioManager.jump);
                RB.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
                animator.SetBool("taPulando", true);
            }
        }

        // Aumentando a pontuação
        if (isAlive)
        {
            score += Time.deltaTime * 2.5f;
            // ScoreText.text = "Score: " + score.ToString("F2");
        }
    }

    IEnumerator controlaMorte()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameOver");
    }

    // Detecta colisão com o chão e obstaculo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Colisão com chão
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
                animator.SetBool("taPulando", false);
            }
        }

        // Colisão com obstaculo
        if (collision.gameObject.CompareTag("obstacle"))
        {
            isAlive = false;
            audioManager.PlaySFX(audioManager.death);
            scoreScript.SaveScore();
            StartCoroutine(controlaMorte());
        }
    }
    







}
