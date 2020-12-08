using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSummoner : MonoBehaviour
{

    public GameObject point;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<10000; i++)
        {
            Instantiate(point, new Vector3(Random.Range(-200, 200), Random.Range(-200, 200), 0), point.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
