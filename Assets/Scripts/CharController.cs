using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    float hor, ver;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal") *speed;
        ver = Input.GetAxis("Vertical")*speed;
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime);
    }
}
