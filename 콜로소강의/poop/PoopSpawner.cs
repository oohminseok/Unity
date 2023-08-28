using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] poops;
    // Start is called before the first frame update
    [SerializeField]
    private float poopInterval=1f;
    void Start()
    {
        StartSpawning();
    }

    private void StartSpawning()
    {
        StartCoroutine(SpawnPoopRoutine());
    }

    private void StopSpawning()
    {
        StopCoroutine(SpawnPoopRoutine());
    }

    IEnumerator SpawnPoopRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        while(true)
        {
            SpawnPoop();
            yield return new WaitForSeconds(poopInterval);
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    private void SpawnPoop()
    {

        float posX=Random.Range(-3f,3f);
        Vector3 position=new Vector3(posX,6,0);
        int index=Random.Range(0,poops.Length);
        Instantiate(poops[index],position,Quaternion.identity);
    }
}
