using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] GameObject trap;
    float _time = 0f;
    float _Cool = 20f;

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;

        if(_time > _Cool && Input.GetButtonDown("Fire3"))
        {
            trap.SetActive(true);
        }
    }
}
