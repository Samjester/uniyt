using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Vector3 startPosition; // Position initiale du joueur
    public float fallThreshold = -10f; // Hauteur où le joueur respawn
    private Rigidbody rb;

    void Start()
    {
        startPosition = transform.position; // Sauvegarde la position de départ
        rb = GetComponent<Rigidbody>(); // Récupère le Rigidbody
    }

    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Désactive la physique du joueur pour éviter les problèmes de mouvement
        rb.isKinematic = true;
        rb.detectCollisions = false;

        // Replace le joueur à sa position de départ
        transform.position = startPosition;

        // Réactive la physique après un court délai
        Invoke(nameof(ReactivatePhysics), 0.1f);
    }

    void ReactivatePhysics()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }
}
