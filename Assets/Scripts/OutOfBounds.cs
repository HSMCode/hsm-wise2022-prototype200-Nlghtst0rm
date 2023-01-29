using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Transform player;
    public float x, y, z;

    public bool gameIsOver;

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.position = new Vector3(x, y, z);
            gameIsOver = true;
        }
    }
}
