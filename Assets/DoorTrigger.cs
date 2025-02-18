using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator doorAnimator; // Référence à l'Animator de la porte
    private bool isDoorOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isDoorOpen) // Vérifie si c'est le joueur
        {
            Debug.Log("Player entered the trigger zone.");
            doorAnimator.SetTrigger("Open");
            isDoorOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isDoorOpen) // Vérifie si c'est le joueur
        {
            Debug.Log("Player exited the trigger zone.");
            doorAnimator.SetTrigger("Close");
            isDoorOpen = false;
        }
    }
}