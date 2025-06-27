using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class WaitForSFXToEnd : MonoBehaviour
{
    public AudioSource audioSource;
    public UnityEvent onSFXEnd;  // Event to trigger after SFX finishes

    private bool hasPlayed = false;

    public string sceneToLoad;

    void Start()
    {
        onSFXEnd.AddListener(() => SceneManager.LoadScene(sceneToLoad));
    }


    void Update()
    {
        if (audioSource == null) return;

        if (audioSource.isPlaying)
        {
            hasPlayed = true;
        }

        if (hasPlayed && !audioSource.isPlaying)
        {
            hasPlayed = false;
            onSFXEnd.Invoke();
        }
    }
}

