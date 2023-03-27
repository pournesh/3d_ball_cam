using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
    public GameObject groundtile;
    Vector3 nextspawnpoint;
    public int spawntilecount;
    // Start is called before the first frame update
    
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundtile, nextspawnpoint, Quaternion.identity);
        nextspawnpoint = temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
       for(int i=0;i<spawntilecount;i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
