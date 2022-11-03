using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rg;
    private float _timer,_timerScore;

    private void Awake()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _timer += Time.deltaTime;
        _timerScore += Time.deltaTime;
        if (_timer > 15)
        {
            if (rg.gravityScale > 0)
            {
                rg.gravityScale += 0.01f;
            }
            else
            {
                rg.gravityScale -= 0.01f;
            }
            _timer = 0;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rg.gravityScale *= -1;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rg.gravityScale *= -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Finish")
        {
            if (PlayerPrefs.GetInt("Score") == 0 || PlayerPrefs.GetInt("Score") < PlayerPrefs.GetInt("Score1"))
            {
                PlayerPrefs.SetInt("Score",(int)_timerScore);
            }
            PlayerPrefs.SetInt("Score1",(int)_timerScore);
            GetComponentInParent<SpawnPlayer>().Destroy();
            Destroy(gameObject);
        }
    }
}
