using System.Collections;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Referencia al componente TextMeshPro Text
    public string[] dialogues; // Di�logos que se mostrar�n
    public Image dialoguePanel; // Referencia al componente Image que representa el panel del di�logo

    private int currentDialogueIndex = 0;
    private bool isShowingDialogue = false;
    private int clickCount = 0;

    private void Start()
    {
        dialogueText.text = ""; // Inicializar el texto del di�logo vac�o
        dialoguePanel.gameObject.SetActive(false); // Desactivar el panel al inicio del juego
    }

    private void Update()
    {
        // Verificar si el jugador hace clic y si se est� mostrando un di�logo
        if (Input.GetMouseButtonDown(0) && isShowingDialogue)
        {
            ShowNextDialogue();
        }
    }

    private void OnMouseDown()
    {
        // Mostrar el di�logo correspondiente al contador de clics
        if (!isShowingDialogue)
        {
            isShowingDialogue = true;
            dialoguePanel.gameObject.SetActive(true); // Activar el panel al mostrar un di�logo
            if (clickCount < dialogues.Length)
            {
                StartCoroutine(ShowDialogue(dialogues[clickCount]));
                clickCount++;
            }
            else
            {
                // Si ya se mostraron todos los di�logos, ocultar el texto, el panel y reiniciar el contador de clics
                dialogueText.text = "";
                clickCount = 0;
                isShowingDialogue = false;
                dialoguePanel.gameObject.SetActive(false);
            }
        }
    }

    private void ShowNextDialogue()
    {
        // No es necesario hacer nada aqu� en este caso
    }

    private IEnumerator ShowDialogue(string dialogue)
    {
        dialogueText.text = ""; // Limpiar el texto antes de mostrarlo
        foreach (char letter in dialogue.ToCharArray())
        {
            dialogueText.text += letter; // Mostrar cada letra una por una
            yield return new WaitForSeconds(0.05f); // Ajusta este valor para controlar la velocidad de aparici�n del texto
        }
        // Cuando se ha mostrado todo el di�logo, ya no se est� mostrando un di�logo
        isShowingDialogue = false;
        dialoguePanel.gameObject.SetActive(false); // Desactivar el panel al finalizar el di�logo
    }
}


