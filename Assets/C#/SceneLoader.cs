using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; // Nombre de la escena a cargar

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verificar si el objeto que colisionó es el jugador
        {
            SceneManager.LoadScene(sceneName); // Cargar la escena especificada
        }
    }
}
