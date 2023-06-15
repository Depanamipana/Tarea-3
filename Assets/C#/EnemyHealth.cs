using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10; // Vida m�xima del enemigo
    private int currentHealth; // Vida actual del enemigo

    void Start()
    {
        currentHealth = maxHealth;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if (collision.gameObject.CompareTag("Player")) // Verificar si la colisi�n es con el jugador
        {
            // Restar vida al enemigo
            TakeDamage(1); // Puedes ajustar el valor de la cantidad de da�o seg�n tus necesidades
        }
        */
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die(); // Si la vida del enemigo llega a 0 o menos, llamar al m�todo Die()
        }
    }

    void Die()
    {
        // Aqu� puedes agregar la l�gica para la muerte del enemigo, como reproducir una animaci�n de muerte, otorgar puntos al jugador, etc.
        Destroy(gameObject); // Destruir el GameObject del enemigo
    }
}
