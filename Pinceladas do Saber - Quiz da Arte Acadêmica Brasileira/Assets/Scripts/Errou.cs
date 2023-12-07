using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Errou : MonoBehaviour
{
    public void VoltarAoInicio()
    {
        SceneManager.LoadScene("Menu");
    }
}