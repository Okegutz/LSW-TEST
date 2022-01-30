using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    [SerializeField] GameObject prefabObjectStore;
    [SerializeField] int maxNumberObjectStore;
    [SerializeField] ObjectTemplate[] storeList;
    [SerializeField] List<ObjectTemplate> temporalyStoreList;

    private Objects _object;

    private void Start()
    {
        temporalyStoreList.AddRange(storeList);
        for (int i=0; i<= maxNumberObjectStore-1; i++)
        {
            GameObject store = GameObject.Instantiate(prefabObjectStore, Vector2.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Store").transform);
            int index = Random.Range(0, temporalyStoreList.Count);
            _object = store.GetComponent<Objects>();
            _object.CreateObject(storeList[index]);
            temporalyStoreList.Remove(temporalyStoreList[index]);
        }
    }
}
