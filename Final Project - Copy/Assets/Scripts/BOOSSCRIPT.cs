using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOSSCRIPT : MonoBehaviour
{
    Rigidbody2D rb;

    public float movespeed;
    public GameObject enemy;
    public GameObject enemy2;
    public Transform Spawn;
    private float randomXposition;
    public Transform spawn;
    public GameObject border;

    public float MinX;
    public float MaxX;
    public float MinY;
    public float MaxY;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnenemy", 0f, 10f);
        int RandomPos = Random.Range(1, 4);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnenemy()
    {
        int RandomPos = Random.Range(1,4);
        if (RandomPos == 1)
        {
            CancelInvoke("spawnenemy3");
            CancelInvoke("move");
            CancelInvoke("spawnenemy2");
            InvokeRepeating("spawnenemy2", 0f, 0.7f);

        }
        else if (RandomPos == 2)
        {
            CancelInvoke("spawnenemy2");
            CancelInvoke("move");
            CancelInvoke("spawnenemy3");
            InvokeRepeating("spawnenemy3", 0f, 0.4f);
        }
        else
        {
            CancelInvoke("move");
            CancelInvoke("spawnenemy3");
            CancelInvoke("spawnenemy2");
            move();
        }


    }

    void spawnenemy2()
    {
        Instantiate(enemy, Spawn);
    }

    void spawnenemy3()
    {
        bool isspawned = false;

        while (!isspawned)
        {
            Vector3 randomXposition = new Vector3(Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
            if ((randomXposition - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(enemy2, randomXposition, Quaternion.identity);
                isspawned = true;
            }
        }
    }

    void move()
    {
        rb.velocity = Vector2.left * 1.8F;
    }
}