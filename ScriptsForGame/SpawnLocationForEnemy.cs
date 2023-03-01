using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLocationForEnemy : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 2)
        {
            xPos = Random.Range(-25,-43);
            zPos = Random.Range(-25,-43);
            Instantiate(theEnemy,new Vector3(xPos,3,zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}
