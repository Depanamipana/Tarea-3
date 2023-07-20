using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public HealthController healthController; // Referencia al componente HealthController
    public TextMeshProUGUI healthText; // Referencia al objeto de texto que mostrará la cantidad de vida

    private void Start()
    {
        // healthText = GetComponent<TextMeshProUGUI>(); // No necesitamos esto ahora, ya que el TextMeshProUGUI ya se asigna en el Inspector
    }

    public void UpdateHealthText(int currentHealth, int maxHealth)
    {
        // Actualiza el texto para mostrar la cantidad actual y máxima de vida
        healthText.SetText("HP: " + currentHealth.ToString() + "/" + maxHealth.ToString());
    }
}
