using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsFire : MonoBehaviour
{
    [SerializeField]
    private float fireTime = 0.05f;

    private void Start()
    {
        InvokeRepeating(nameof(Fire),fireTime,fireTime);
    }

    private void Fire()
    {
       var getPooledObj = NewObjPooled.Current.GetPooledObj();

       if (getPooledObj == null) return;
       getPooledObj.transform.position = transform.position;
       getPooledObj.transform.rotation = transform.rotation;
       getPooledObj.SetActive(true);
    }
}
