using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHealth : MonoBehaviour
{
    public int healthAmount = 1; // Cantidad de vida que se agregará al jugador al colisionar
    public AudioClip collectSound; // Sonido que se reproducirá al recoger el objeto (opcional)

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Comprobar si el objeto colisionado es el jugador
        if (other.CompareTag("Player"))
        {
            // Obtener el componente HealthController del jugador
            HealthController playerHealth = other.GetComponent<HealthController>();

            // Asegurarse de que se encontró el componente HealthController
            if (playerHealth != null)
            {
                // Agregar vida al jugador
                playerHealth.TakeDamage(-healthAmount);

                // Reproducir el sonido si está definido
                if (collectSound != null)
                {
                    AudioSource.PlayClipAtPoint(collectSound, transform.position);
                }
            }

            // Desactivar el objeto
            gameObject.SetActive(false);
        }
    }
}
