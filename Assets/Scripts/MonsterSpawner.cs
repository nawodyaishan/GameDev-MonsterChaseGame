using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField] private Transform leftPos, rightPos;

    private int randomIndex;

    private int randomSide;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnedMonsters());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator SpawnedMonsters()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
    }
}