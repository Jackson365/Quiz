using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespostaErrada : MonoBehaviour
{
    public void ResErrada()
    {
        SceneManager.LoadScene("Errou");
    }
}
