using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundenemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public GameObject enemy;
    public Transform spawnright;
    public Transform spawnleft;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.right * speed;

        InvokeRepeating("spawnenemy", 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
