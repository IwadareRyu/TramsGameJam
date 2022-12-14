using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] float _limitTime;
    [SerializeField]Text _text;
    [SerializeField] GameObject _go1;
    [SerializeField] GameObject _go2;
    GameObject _waterMelon;
    [SerializeField] string sceneName;

    void Start()
    {
        _waterMelon = GameObject.FindGameObjectWithTag("Suica");
    }

    void Update()
    {
        if(_waterMelon == true)
        {
            float time = Mathf.Clamp(_limitTime -= Time.deltaTime, 0, _limitTime);
            _text.text = time.ToString("00.00") + "?b";
        }

        if(_limitTime <= 0)
        {
            _go1.SetActive(true);
            _limitTime = 0;
            StartCoroutine(LoadTime());
        }
        else if(_waterMelon == false)
        {
            _go2.SetActive(true);
            StartCoroutine(LoadTime());
        }
    }
    IEnumerator LoadTime()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(sceneName);
    }
}
