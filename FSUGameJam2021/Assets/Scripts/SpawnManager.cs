using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PickEnemy();
    }

    void PickEnemy()
    {
        int enemyChoice = Random.Range(0, 1);
        Instantiate(enemyPrefab[enemyChoice], transform.position, transform.rotation);
    }
}
