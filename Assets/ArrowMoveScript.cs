using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMoveScript : MonoBehaviour
{
    public float moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * moveSpeed) * Time.deltaTime;

        if (transform.position.y < -12)
        {
            Debug.Log("Arrow exited screen, got destroyed");
            Destroy(gameObject);
        }

    }
}
