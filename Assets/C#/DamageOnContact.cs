using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageOnContact : MonoBehaviour
{
    [SerializeField] private int damageAmount = 10; // Cantidad de da�o al recibir una colisi�n

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobar si la colisi�n proviene de un objeto con el tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Restar vida al personaje
            collision.gameObject.GetComponent<HealthController>().TakeDamage(damageAmount);
        }
    }
}
