using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    SpriteRenderer sprite;
    public bool facingright = true;

    public GameObject bullet;
    GameObject BulletClone;
    public int speed;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();

        if (Input.GetKeyDown(KeyCode.A))
        {

            facingright = false;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

            facingright = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            facingright = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            facingright = true;

        }
    }

    void Fire()
    {
        if (Input.GetMouseButtonDown(0) && facingright)
        {
            BulletClone = Instantiate(bullet, transform.position, transform.rotation);
            BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(BulletClone, 1f);
        }

        else if (Input.GetMouseButtonDown(0) && !facingright)
        {
            BulletClone = Instantiate(bullet, transform.position, transform.rotation);
            BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(BulletClone, 1f);
        }

    }

}

