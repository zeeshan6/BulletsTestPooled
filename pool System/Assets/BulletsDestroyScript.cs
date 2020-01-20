using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsDestroyScript : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(Destroy),5f);
    }
    private void Destroy()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
