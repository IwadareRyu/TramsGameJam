using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedController : MonoBehaviour
{
    [SerializeField] float _speed;
    private GameObject _watermelon;
    private WatermelonController _watermeloncs;
    //private GameObject _player;
    //private PlayerController _playercs;
    private float _timer;
    [SerializeField] float _destroytime = 3;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        _watermelon = GameObject.FindGameObjectWithTag("Suica");
        _watermeloncs = _watermelon.GetComponent<WatermelonController>();
        rb.velocity = Vector2.right * _speed * _watermeloncs._l;
        //_player = GameObject.Find("player");
        //_playercs = GetComponent<PlayerController>();
    }
    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _destroytime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    _playercs.Confution();
        //}
    }
}
