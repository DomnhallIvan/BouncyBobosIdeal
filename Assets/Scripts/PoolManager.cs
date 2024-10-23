using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject prefabToCreate;
    public List<GameObject> createObjects;

    private void Start()
    {
        createObjects = new List<GameObject>();
        StartFunction();
    }

    public GameObject AskForObject(Vector3 position)
    {
        //poner algo más en for (int i), por ejemplo el indexObject
        for(int indexObject=0;indexObject<createObjects.Count;indexObject++) 
        {
            if (!createObjects[indexObject].activeInHierarchy)
            {
                createObjects[indexObject].SetActive(true);
                return createObjects[indexObject];
            }
        }
        GameObject createdObject=Instantiate(prefabToCreate,position,Quaternion.identity);
        createObjects.Add(createdObject);
        return createdObject;
    }

    public virtual void StartFunction()
    {

    }
}
