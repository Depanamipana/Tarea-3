using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopAudioOnSceneChange : MonoBehaviour
{
    public GameObject pauseMenu; // Asigna el objeto del menú de pausa desde el Inspector
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Update()
    {
        if (pauseMenu != null)
        {
            if (pauseMenu.activeSelf)
            {
                PauseAudio();
            }
            else
            {
                ResumeAudio();
            }
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StopAudio();
    }

    private void PauseAudio()
    {
        if (audioSource != null && audioSource.isPlaying && !audioSource.mute)
        {
            audioSource.Pause();
        }
    }

    private void ResumeAudio()
    {
        if (audioSource != null && !audioSource.isPlaying && !audioSource.mute)
        {
            audioSource.UnPause();
        }
    }

    private void StopAudio()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
