using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerate : MonoBehaviour
{
    SpawnTrigger fs;
    // Start is called before the first frame update
    void Start()
    {
        fs = GameObject.FindObjectOfType<SpawnTrigger>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        fs.SpawnTile();
        //fs.SpawnPlot();
        Destroy(transform.parent.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
