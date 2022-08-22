using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapIObj : MonoBehaviour
{
    GameObject _suica;
    PlayerController _player;
    float _loadSpeed;
    bool _time;

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
        if (collision.gameObject.tag == "Player" && !_time)
        {
            _loadSpeed = _player._speed;
            _time = true;
            _player._speed = 0f;
            StartCoroutine(TrapTime());
        }
    }
    IEnumerator TrapTime()
    {
        yield return new WaitForSeconds(5f);
        _player._speed = _loadSpeed;
        gameObject.SetActive(false);
    }
}
