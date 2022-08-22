using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed;
    private GameObject _watermelon;
    private WatermelonController _watermeloncs;
    private 
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        _watermelon = GameObject.FindGameObjectWithTag("Suica");
        _watermeloncs = _watermelon.GetComponent<WatermelonController>();
        rb.velocity = Vector2.right * _speed * _watermeloncs._l;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = GetComponent<PlayerController>();
            player.Confution();
        }
    }
}
