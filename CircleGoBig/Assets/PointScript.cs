using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public float min = 0.5f;
    public float max = 5f;

    private float size;

    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(min, max);
        transform.localScale = new Vector3(size, size, 1);

        Color randomColor = new Color(
        Random.Range(0f, 1f),
        Random.Range(0f, 1f),
        Random.Range(0f, 1f),
        1);
        GetComponent<SpriteRenderer>().color = randomColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
