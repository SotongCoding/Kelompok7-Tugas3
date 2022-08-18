using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SpaceInvader.Character;
public class UFOSpawner : MonoBehaviour
{
    [SerializeField] UFO_View ufoPrefabs;
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
            UFO_View ufo = Instantiate(ufoPrefabs, transform.position, Quaternion.identity);
            UFO_Controller control = new UFO_Controller();

            control.Init(ufo);
            yield return new WaitForSeconds(20f);
        }
    }
}
