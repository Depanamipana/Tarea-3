using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] enemies; // Aquí se asignan los enemigos que aparecen en la escena
    public GameObject portal; // Aquí se asigna el sprite del portal que aparecerá después de destruir a todos los enemigos

    void Start()
    {
        // Buscar todos los objetos con el tag "Enemy" y agregarlos al array de enemigos
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void Update()
    {
        int counter = 0;
        // Si no quedan enemigos en la escena
        for (int i = 0; i < enemies.Length; i++)
        {
            if(enemies[i] == null)
            {
                counter += 1;
            } 
        }

        if (enemies.Length == counter)
        {
            // Activar el sprite del portal
            portal.SetActive(true);
        }
    }
}
