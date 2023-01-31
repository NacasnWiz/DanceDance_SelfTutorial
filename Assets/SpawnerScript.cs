using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject UpArrow;
    public GameObject RightArrow;
    public GameObject DownArrow;
    public GameObject LeftArrow;
    public logicScript logic;

    private int arrowType;
    private GameObject arrow;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        SpawnArrow();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < logic.spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            arrowType = Random.Range(0, 4);
            SpawnArrow();
            timer = 0;
        }

    }

    void SpawnArrow()
    {
        switch (arrowType)
        {
            case 0:
                arrow = UpArrow; break;
            case 1:
                arrow = RightArrow; break;
            case 2:
                arrow = DownArrow; break;
            case 3:
                arrow = LeftArrow; break;
        }

        Instantiate(arrow, transform.position, transform.rotation);
    }
}
