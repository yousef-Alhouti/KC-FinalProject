using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Rigidbody2D enemyRigidBody2D;
    public int UnitsToMove = 5;
    public float EnemySpeed = 500;
    public bool _isFacingRight;
    public bool _isFacingLeft;
    private float _startPos;
    private float _endPos;
    private float _endPos2;

    public bool _moveRight = true;
    public bool _moveLeft = false;


    // Use this for initialization
    public void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();
        _startPos = transform.position.x;
        _endPos = _startPos + UnitsToMove;
        _endPos2 = _startPos - UnitsToMove;
        _isFacingRight = transform.localScale.x > 0;
        _isFacingLeft = transform.localScale.x < 0;
    }


    // Update is called once per frame
    public void Update()
    {

        if (_moveRight)
        {
            enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
            if (!_isFacingRight)
                Flip();
        }

        if (enemyRigidBody2D.position.x >= _endPos)
            _moveRight = false;

        if (!_moveRight)
        {
            enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
            if (_isFacingRight)
                Flip();
        }
        if (enemyRigidBody2D.position.x <= _startPos)
            _moveRight = true;



        if (_moveLeft)
        {
            enemyRigidBody2D.AddForce(Vector2.left * EnemySpeed * Time.deltaTime);
            if (!_isFacingLeft)
                Flip();
        }

        if (enemyRigidBody2D.position.x >= _endPos2)
            _moveLeft = false;

        if (!_moveLeft)
        {
            enemyRigidBody2D.AddForce(-Vector2.left * EnemySpeed * Time.deltaTime);
            if (_isFacingLeft)
                Flip();
        }
        if (enemyRigidBody2D.position.x >= _startPos)
            _moveLeft = true;


    }

    public void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _isFacingRight = transform.localScale.x > 0;
    }

}
