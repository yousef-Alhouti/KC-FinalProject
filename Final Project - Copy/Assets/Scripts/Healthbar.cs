using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Healthbar : MonoBehaviour
{
    public float health = 100;
    public float inc = 0.000000000001F;

    public GameObject explosion;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public GameObject healthbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Transision();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            move();
            health -= 1;
        }
    }

    void Transision()
    {
        SceneManager.LoadScene(5);    
    }
    
    void move()
    {
        healthbar.transform.Translate(-0.0334F, 0F, 0F);
    }
}
