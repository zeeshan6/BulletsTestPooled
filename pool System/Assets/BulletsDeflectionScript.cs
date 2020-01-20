using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsDeflectionScript : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed = 5f;

    private void Update()
    {
        transform.Translate(0,bulletSpeed * Time.deltaTime,0);
    }

}
