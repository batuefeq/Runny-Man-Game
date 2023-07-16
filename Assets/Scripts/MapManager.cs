using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private GameObject mapPrefab, levelHandler;


    

    private void OnEnable()
    {
        if (levelHandler == null)
        {
            print("it is null");
            levelHandler = GameObject.FindGameObjectWithTag("EndPoint");
        }
    }

    private void MapSpawner()
    {      
         Instantiate(mapPrefab, levelHandler.GetComponent<LevelHandler>().endPointTransform);              
    }


    void Update()
    {
        MapSpawner();
    }
}
