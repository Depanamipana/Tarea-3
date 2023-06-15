using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100; // Vida m�xima del personaje
    [SerializeField] private int damageAmount = 10; // Cantidad de da�o al recibir una colisi�n
    [SerializeField] private string sceneToLoad = "GameOverScene"; // Nombre de la escena a cargar cuando la vida llegue a 0

    private int currentHealth; // Vida actual del personaje
    private Transform lastCheckpoint; // �ltimo checkpoint alcanzado

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobar si la colisi�n proviene de un objeto con el tag "Enemy"
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Restar vida al personaje
            TakeDamage(damageAmount);
        }
    }

    public void TakeDamage(int amount)
    {
        // Restar la cantidad de da�o a la vida actual
        currentHealth -= amount;

        // Comprobar si la vida ha llegado a 0
        if (currentHealth <= 0)
        {
            // Cargar la escena de Game Over
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void UpdateLastCheckpoint(Transform checkpoint)
    {
        lastCheckpoint = checkpoint;
    }
}

