using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOSpawner : MonoBehaviour
{
    [SerializeField] GameObject ufoPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnUFO());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnUFO()
    {
        yield return new WaitForSeconds(10f);
        while (true)
        {
            Instantiate(ufoPrefabs, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(20f);
        }
    }
}
