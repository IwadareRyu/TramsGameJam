using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject _Attack;
    [SerializeField] GameObject _confuse;
    [SerializeField] float _speed = 5f;
    
    Rigidbody2D _rb;
    float _h;
    float _v;
    [SerializeField]float _ac = 1.5f;
    [SerializeField] float _cc = 3f;
    bool _coolTime;
    bool _confuseTime;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_coolTime && !_confuseTime)
        {
            _h = Input.GetAxis("Horizontal");
            _v = Input.GetAxis("Vertical");
        }
        FlipX(_h);
        if(Input.GetButtonDown("Fire1") && !_coolTime)
        {
            _Attack.gameObject.SetActive(true);
            _coolTime = true;
            _h = 0;
            _v = 0;
            StartCoroutine(AttackTime());
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
        }
        else if(Horizontal < 0)
        {
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
        }

    }
    public void Confution()
    {
        _confuseTime = true;
        _confuse.gameObject.SetActive(true);
        StartCoroutine(ConfuseTime());
    }
    IEnumerator AttackTime()
    {
        yield return new WaitForSeconds(1f);
        _Attack.gameObject.SetActive(false);

        yield return new WaitForSeconds(_ac);
        _coolTime = false;
    }
    IEnumerator ConfuseTime()
    {
        yield return new WaitForSeconds(_cc);
        _confuseTime = false;
        _confuse.gameObject.SetActive(false);

    }
}
