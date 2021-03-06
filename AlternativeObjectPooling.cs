// Hasn't tested yet

using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static GameObject[] objectToPool;
    public static int[] amountToPool;
    private static List<List<GameObject>> _objectPools;
    
    private void Start()
    {
        // Creates poolers list
        _objectPools = new List<List<GameObject>>();
        
        // Fills the list with poolers
        for (int i = 0; i < objectToPool.Length; i++)
        {
            _objectPools.Add(new List<GameObject>());
        }
        
        /* Fills poolers with GameObject */
        // For every pooler in poolers list
        for (int i = 0; i < _objectPools.Count; i++)
        {
            // Define a GameObject
            GameObject tmp;
            // For every pool
            for (int j = 0; j < amountToPool[i]; j++)
            {
                // Create GameObject
                tmp = Instantiate(objectToPool[i]);
                // Deactivate it
                tmp.SetActive(false);
                // Add it to pooler
                _objectPools[i].Add(tmp);
            }
        }
    }
    
    public static GameObject GetPooledObject(int poolNumber)
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
