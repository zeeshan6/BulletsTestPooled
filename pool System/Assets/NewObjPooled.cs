using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewObjPooled : MonoBehaviour
{
    public static NewObjPooled Current;
    
    [SerializeField]
    private GameObject pooledObj;
    
    [SerializeField]
    private int pooledAmount = 100;

    [SerializeField] 
    private bool willGrow = true;

    private List<GameObject> _pooledObjs;
    private void Awake()
    {
        Current = this;
    }
    private void Start()
    {
        _pooledObjs = new List<GameObject>();
        for (var i = 0; i < pooledAmount; i++)
        {
            var obj = Instantiate(pooledObj);
            obj.SetActive(false);
            _pooledObjs.Add(obj);
        }
    }

    public GameObject GetPooledObj()
    {
        for (var i = 0; i < _pooledObjs.Count; i++)
        {
            if (!_pooledObjs[i].activeInHierarchy)
            {
                return _pooledObjs[i];
            }
        }

        if (!willGrow) return null;
        var obj = Instantiate(pooledObj);
        _pooledObjs.Add(obj);
        return obj;
    }
}
