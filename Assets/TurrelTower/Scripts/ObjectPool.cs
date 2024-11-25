using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject[] prefabs;
    [SerializeField] private Transform _container;
    [SerializeField] private int poolSize = 8;

    private Dictionary<GameObject, Queue<GameObject>> pool;

    void Start()
    {
        pool = new Dictionary<GameObject, Queue<GameObject>> ();
        
        foreach (var prefab in prefabs)
        {
            Queue<GameObject> objectQueue = new Queue<GameObject>();

            for (int i = 0; i < poolSize; i++)
        
            AddObjectToPool(prefab, objectQueue);
            pool[prefab] = objectQueue;
        }
    }
    private void AddObjectToPool(GameObject prefab, Queue<GameObject> queue)
    {
        GameObject obj = Instantiate(prefab);
        obj.SetActive(false);
        queue.Enqueue(obj);
        obj.transform.parent = _container;
    }
    public GameObject GetObject(GameObject prefab)
    {
        if (pool.ContainsKey(prefab) && pool[prefab].Count > 0)
        {
            GameObject obj = pool[prefab].Dequeue();
            obj.SetActive(true);
            return obj;
        }
        else
        {
            GameObject obj = Instantiate(prefab, _container);
            return obj;
        }
        
    }

    public void ReturnObject(GameObject prefab, GameObject obj)
    {
        if (!pool.ContainsKey(prefab))
        {
            pool[prefab] = new Queue<GameObject>();
        }

        obj.SetActive(false); 
        pool[prefab].Enqueue(obj); 
        obj.transform.parent = _container;
    }
}