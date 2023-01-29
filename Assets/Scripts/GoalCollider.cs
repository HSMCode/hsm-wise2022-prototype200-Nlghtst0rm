using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollider : MonoBehaviour
{
    public Transform player;
    public float x, y, z;

    public bool YouWon;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.position = new Vector3(x, y, z);
            YouWon = true;
        }
    }
}
