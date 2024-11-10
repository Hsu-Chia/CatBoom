using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawn_test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject catPrefab;
    [SerializeField]
    GameObject Spawnposition;

    void Start()
    {
        RebornCat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RebornCat()
    {
         Instantiate(catPrefab, Spawnposition.transform.position, Quaternion.identity);

    }
}
