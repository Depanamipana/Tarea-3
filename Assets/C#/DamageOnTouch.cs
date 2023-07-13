using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    [SerializeField] private int damageAmount = 10; // la cantidad de da�o que inflige al jugador
    private HealthController healthController; // referencia al componente HealthController del jugador

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto que toca tiene un componente HealthController, lo almacena en healthController
        healthController = other.GetComponent<HealthController>();

        // Si el objeto que toca tiene un componente HealthController, lo da�a
        if (healthController != null)
        {
            healthController.TakeDamage(damageAmount);
        }
    }
}
