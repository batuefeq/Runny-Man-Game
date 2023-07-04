using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandlerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy, obstacle;


    private void Awake()
    {
        StartCoroutine(GameobjectSpawner());
    }


    private IEnumerator GameobjectSpawner()
    {
        print("inside");
        Instantiate(enemy);
        yield return new WaitForSeconds(3f);
        print("outside");
    }
  
    void Update()
    {       
        
    }
}
