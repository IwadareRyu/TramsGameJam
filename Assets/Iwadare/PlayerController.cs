using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject _Attack;
    [SerializeField] float _speed = 5f;
    
    Rigidbody2D _rb;
    float _h;
    float _v;
    bool _coolTime;
    float minas;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxis("Horizontal");
        _v = Input.GetAxis("Vertical");
        FlipX(_h);
        if(Input.GetButtonDown("Fire1") && !_coolTime)
        {
            _Attack.gameObject.SetActive(true);
            _coolTime = true;
        }
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_h * _speed, _v * _speed);
    }
    void FlipX(float Horizontal)
    {
        if(Horizontal > 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x),transform.localScale.y,transform.localScale.z);
            minas = 1;
        }
        else if(Horizontal < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
            minas = -1;
        }

    }
}
