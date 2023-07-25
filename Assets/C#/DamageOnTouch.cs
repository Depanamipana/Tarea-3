using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageOnContact : MonoBehaviour
{
    [SerializeField] private int damageAmount = 10; // Cantidad de da�o al contacto

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobar si la colisi�n proviene de un objeto con el tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Restar vida al jugador
            collision.gameObject.GetComponent<HealthController>().TakeDamage(damageAmount);
        }
    }
}
