using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemies : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
