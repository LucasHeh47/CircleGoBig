using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform transform;
    public float size;

    public float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        size = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(size, size, 1);

        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed/size * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            if (collision.gameObject.transform.localScale.x < size)
            {
                size += collision.gameObject.transform.localScale.x/5;
                Destroy(collision.gameObject);
            }
        }
    }

}
