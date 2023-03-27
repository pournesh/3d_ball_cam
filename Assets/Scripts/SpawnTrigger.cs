using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public GameObject groundtile;
    Vector3 nextspawnpoint,leftspawnplot;
    public int spawntilecount;
    GameObject lhouse;
    

    public List<GameObject> Plots;
    // Start is called before the first frame update

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundtile, nextspawnpoint, Quaternion.identity);

        lhouse = Plots[Random.Range(0, Plots.Count)];
        Debug.Log("house" + lhouse);

        GameObject temp1 = Instantiate(lhouse, new Vector3(-15,nextspawnpoint.y,0), Quaternion.identity);


        nextspawnpoint = temp.transform.GetChild(1).transform.position;


    }
    public void SpawnPlot()
    {
        lhouse = Plots[Random.Range(0, Plots.Count)];
        Debug.Log("house"+lhouse);

        GameObject temp = Instantiate(lhouse, leftspawnplot, Quaternion.identity);
        leftspawnplot = temp.transform.GetChild(2).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < spawntilecount; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
