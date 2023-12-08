using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespostaErrada : MonoBehaviour
{
    public AudioClip somErrado;
    private AudioSource _audioSource;

    private void CarregarPCena()
    {
        SceneManager.LoadScene("Errou");
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ClicBotão()
    {
        _audioSource.PlayOneShot(somErrado);
        Invoke("CarregarPCena", 0.5f);
    }
}
