using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float _deathTime;

    void Update()
    {
        Destroy(gameObject, _deathTime);
    }
}
