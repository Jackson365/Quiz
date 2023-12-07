using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GarregarOJogo()
    {
        SceneManager.LoadScene("Pergunta1");
    }

    public void VoltarAoInicio()
    {
        SceneManager.LoadScene("Menu");
    }
}
