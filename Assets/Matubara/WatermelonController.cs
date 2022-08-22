using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonController : MonoBehaviour
{
    public float _moveSpeed;
    [SerializeField] GameObject _seed;
    Rigidbody2D _rb;
    float _h;
    float _v;
    public float _l = 1;
    [SerializeField] float _skillcooltime;
    float _timer = default;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        _h = Input.GetAxisRaw("WMHorizontal");
        _v = Input.GetAxisRaw("WMVertical");
        Debug.Log(_timer);
        if (_timer > _skillcooltime)
        {
            UseSkill();
        }
        FlipX(_h);
    }
    private void FixedUpdate()
    {
        Vector3 dom = new Vector3(_h, _v).normalized;
        _rb.velocity = dom * _moveSpeed;
    }
    void UseSkill()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(_seed, transform.position, transform.rotation);
            _timer = 0;
        }
    }
    void FlipX(float horizontal)
    {
        if (horizontal > 0)
        {
            this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            _l = 1;
        }
        else if (horizontal < 0)
        {
            this.transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
            _l = -1;
        }
    }
}
