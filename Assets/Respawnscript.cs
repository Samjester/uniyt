using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Respawnscript : MonoBehaviour
{
 [SerializeField] private Transform player;
 [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }

}