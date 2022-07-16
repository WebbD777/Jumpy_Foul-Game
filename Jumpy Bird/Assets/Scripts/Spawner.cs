using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] eneReference;
    [SerializeField] private Transform upPos, downPos;
    [SerializeField] private float wait = 2;

    private int ranIndex;
    private int ranSide;

    private GameObject spawnedMon;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnMonster(){

        while (true){

            yield return new WaitForSeconds(wait);

            ranIndex = Random.Range(0,eneReference.Length);

            spawnedMon = Instantiate(eneReference[ranIndex]);

            if (ranIndex == 2 || ranIndex == 3){
                spawnedMon.transform.position = upPos.position;

            }
            else{
                spawnedMon.transform.position = downPos.position;
            }

        }
    }
}
