using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _limitTime;
    [SerializeField]Text _text;
    [SerializeField] GameObject _go;

    void Update()
    {
        float time = Mathf.Clamp(_limitTime -= Time.deltaTime, 0, _limitTime);
        _text.text = time.ToString("00.00")+ "•b";

        if(_limitTime <= 0)
        {
            _go.SetActive(true);
            _limitTime = 0;
        }
    }
}
