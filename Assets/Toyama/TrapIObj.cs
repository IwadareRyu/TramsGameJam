using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapIObj : MonoBehaviour
{
    GameObject _suica;
    PlayerController _player;

    private void Awake()
    {
        _suica = GameObject.Find("WaterMelon");
        _player = FindObjectOfType<PlayerController>();
    }
    void Start()
    {
        gameObject.transform.position = _suica.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _player._speed = 0f;
            gameObject.SetActive(false);
        }
    }
}
