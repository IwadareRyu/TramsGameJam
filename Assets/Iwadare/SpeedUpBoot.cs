using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpBoot : MonoBehaviour
{
    GameObject _watermelon;
    private WatermelonController _watermelonc;
    GameObject _player;
    private PlayerController _playerc;
    // Start is called before the first frame update
    void Start()
    {
        //_player = GameObject.FindGameObjectWithTag("Player");
        //_watermelon = GameObject.FindGameObjectWithTag("Suica");
        //_playerc = GetComponent<PlayerController>();
        //_watermelonc = GetComponent<WatermelonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _playerc = GetComponent<PlayerController>();
            _playerc._speed += 1f;
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "Suica")
        {
            _watermelonc = GetComponent<WatermelonController>();
            _watermelonc._moveSpeed += 1f;
            Destroy(this.gameObject);
        }
    }
}
