using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    /// <summary>
    /// https://docs.unity3d.com/ScriptReference/AudioSource-isPlaying.html?_ga=2.100460699.420587413.1635820398-654658616.1634691982
    /// Helped me for below methods
    /// </summary>


    // public AudioClip clip;
    AudioSource audioSource;
    [SerializeField] GameObject _gameState;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameState.Instance.IsGameOverScore()) {
            audioSource.Pause();
        }


        if (!audioSource.isPlaying)
        {
            GameState.Instance.InitiateGameOver();
            //audioSource.clip = otherClip;
            //audioSource.Play();
        }
    }
}
