using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonController : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    [SerializeField] GameObject _seed;
    Rigidbody2D _rb;
    float _h;
    float _v;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxisRaw("WMHorizontal");
        _v = Input.GetAxisRaw("WMVertical");
    }
    private void FixedUpdate()
    {
        Vector3 dom = new Vector3(_h, _v).normalized;
        _rb.velocity = dom * _moveSpeed;
    }
    void Seedshoot()
    {

    }
}
