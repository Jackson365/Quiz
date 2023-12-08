using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResportaCorreta : MonoBehaviour
{
    
    public AudioClip somCorreto;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void ClicBotão1()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta1", 0.5f);
    }

    public void ClicBotão2()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta2", 0.5f);
    }
    
    public void ClicBotão3()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta3", 0.5f);
    }
    
    public void ClicBotão4()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta4", 0.5f);
    }
    
    public void ClicBotão5()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta5", 0.5f);
    }
    
    public void ClicBotão6()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta6", 0.5f);
    }
    
    public void ClicBotão7()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta7", 0.5f);
    }
    
    public void ClicBotão8()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta8", 0.5f);
    }
    
    public void ClicBotão9()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta9", 0.5f);
    }
    
    public void ClicBotão10()
    {
        audioSource.PlayOneShot(somCorreto);
        Invoke("Correta10", 0.5f);
    }
    
    public void Correta1()
    {
        SceneManager.LoadScene("Pergunta2");
    }

    public void Correta2()
    {
        SceneManager.LoadScene("Pergunta3");
    }

    public void Correta3()
    {
        SceneManager.LoadScene("Pergunta4");
    }
    
    public void Correta4()
    {
        SceneManager.LoadScene("Pergunta5");
    }
    
    public void Correta5()
    {
        SceneManager.LoadScene("Pergunta6");
    }
    
    public void Correta6()
    {
        SceneManager.LoadScene("Pergunta7");
    }
    
    public void Correta7()
    {
        SceneManager.LoadScene("Pergunta8");
    }
    
    public void Correta8()
    {
        SceneManager.LoadScene("Pergunta9");
    }
    
    public void Correta9()
    {
        SceneManager.LoadScene("Pergunta10");
    }
    
    public void Correta10()
    {
        SceneManager.LoadScene("Acertou");
    }
}
