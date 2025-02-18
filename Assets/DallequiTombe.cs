using UnityEngine;

public class DalleQuiTombe : MonoBehaviour
{
    private Rigidbody rb;
    private bool estTombee = false; // Pour éviter de déclencher la chute plusieurs fois

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !estTombee)
        {
            estTombee = true;
            Invoke("FaireTomber", 0.1f); // Délai de 0.5 secondes
        }
    }

    void FaireTomber()
    {
        rb.isKinematic = false;
        // Ajoutez ici les effets visuels et sonores
        Destroy(gameObject, 1f);
    }
}

