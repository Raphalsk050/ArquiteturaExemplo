using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float _horizontal;
    private float _vertical;
    private Rigidbody2D playerRig;
    private Vector2 movementDirection;
    public Weapon weapon;

    private void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _vertical = Input.GetAxisRaw("Vertical");
        _horizontal = Input.GetAxisRaw("Horizontal");
        movementDirection = new Vector2(_horizontal, _vertical).normalized;
    }

    private void FixedUpdate()
    {
        playerRig.velocity = movementDirection * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemyObj = other.gameObject;
            enemyObj.GetComponent<EnemyLife>().TakeDamage(weapon.damage);
        }
    }
}
