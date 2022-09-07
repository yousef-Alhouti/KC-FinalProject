using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D player;

    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask GroundLayer;
    public bool isTouchingGround;
    private float MoveSpeed = 1.5F;
    public bool isjumping;
    public bool facingright;
    public float speed;
    public GameObject bullet;
    GameObject BulletClone;
  


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider2D1 = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, GroundLayer);
        isTouchingGround = collider2D1;


        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * MoveSpeed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, 3);
            isjumping = true;
        }

        if (!Input.GetButtonDown("Jump") && isTouchingGround)
        {
            isjumping = false;
        }

        Fire();
    }

    void Fire()
    {
        if (Input.GetMouseButtonDown(0) && facingright && isjumping)
        {
            BulletClone = Instantiate(bullet, transform.position, transform.rotation);
            BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(BulletClone, 1.5f);
        }

        else if (Input.GetMouseButtonDown(0) && !facingright && isjumping)
        {
            BulletClone = Instantiate(bullet, transform.position, transform.rotation);
            BulletClone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(BulletClone, 1.5f);
        }

    }



}
