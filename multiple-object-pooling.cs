using System.Collections.Generic;
using UnityEngine;


public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public GameObject[] objectToPool;
    public int[] amountToPool;
    private List<List<GameObject>> _objectPools;

    private void Awake()
    {
        SharedInstance = this;
    }
    private void Start()
    {
        // Creates poolers list
        _objectPools = new List<List<GameObject>>();
        
        // Fills the list with poolers
        for (int i = 0; i < objectToPool.Length; i++)
        {
            _objectPools.Add(new List<GameObject>());
        }
        
        // Fills poolers with GameObject
        
        // For every pooler in poolers list
        for (int i = 0; i < _objectPools.Count; i++)
        {
            GameObject tmp;
            // For every pool
            for (int j = 0; j < amountToPool[i]; j++)
            {
                // Create GameObject
                tmp = Instantiate(objectToPool[i]);
                // Deactive it
                tmp.SetActive(false);
                // Add it to pooler
                _objectPools[i].Add(tmp);
            }
        }
    }
    
    public GameObject GetPooledObject(int poolNumber)
    {
        // For every object in the pool
        for (int i = 0; i < amountToPool[poolNumber]; i++)
        {
            // If object isn't active
            if (!_objectPools[poolNumber][i].activeInHierarchy)
            {
                // Return the inactive object
                return _objectPools[poolNumber][i];
            }
        }
        return null;
    }
}
