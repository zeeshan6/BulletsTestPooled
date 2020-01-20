using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsDirectionScript : MonoBehaviour
{ 
    [SerializeField]
    [Range(5f,50f)]
    private float bulletSpeed = 30f;

    private void Update()
    {
        transform.Translate(0,bulletSpeed * Time.deltaTime,0);
    }

}
