using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Suica")
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Seed")
        {
            Destroy(collision.gameObject);
        }
    }
}
