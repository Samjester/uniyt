using UnityEngine;

public class Lever : MonoBehaviour
{
    public Animator doorAnimator; // Référence à l'Animator de la porte
    public string interactionButton = "E"; // Touche pour interagir
    private bool playerInRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player is near the lever.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player is no longer near the lever.");
        }
    }

    private void Update()
{
    if (playerInRange && Input.GetButtonDown("Fire1")) // Use "Fire1"
    {
        doorAnimator.SetTrigger("Open");
        Debug.Log("Door opened!");
    }
}
}