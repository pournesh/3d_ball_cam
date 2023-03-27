using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundtile : MonoBehaviour
{
    FloorSpawner fs;
    // Start is called before the first frame update
    void Start()
    {
        fs = GameObject.FindObjectOfType<FloorSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        fs.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
