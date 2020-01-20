using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsFire : MonoBehaviour
{
    [SerializeField]
    private float fireTime = 0.05f;

    [SerializeField] 
    [Range(100f,1000f)]
    private float spaceSpeed = 200f;
    
    private Rigidbody2D _rigidbody2D;
    private void Start()
    {
        InvokeRepeating(nameof(Fire),fireTime,fireTime);
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey("left"))
        {
            _rigidbody2D.velocity = Time.deltaTime * spaceSpeed * Vector2.left;
        }else if (Input.GetKey("right"))
        {
            _rigidbody2D.velocity = Time.deltaTime * spaceSpeed * Vector2.right;
        }else if (Input.GetKey("up"))
        {
            _rigidbody2D.velocity = Time.deltaTime * spaceSpeed * Vector2.up;
        }else if (Input.GetKey("down"))
        {
            _rigidbody2D.velocity = Time.deltaTime * spaceSpeed * Vector2.down;
        }
        else
        {
            _rigidbody2D.velocity = Vector2.zero;
        }
    }

    private void Fire()
    {
        if (!Input.GetKey("space")) return;
        var getPooledObj = NewObjPooled.Current.GetPooledObj();

        if (getPooledObj == null) return;
        getPooledObj.transform.position = transform.position;
        getPooledObj.transform.rotation = transform.rotation;
        getPooledObj.SetActive(true);
    }
}
