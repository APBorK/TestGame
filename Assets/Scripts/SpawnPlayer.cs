using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player,_game,_panel,_wall;
    [SerializeField] private Transform _startPoint;
    
    private void OnEnable()
    {
        Instantiate(_player,_startPoint);
    }

    public void Destroy()
    {
        _game.SetActive(false);
        _panel.SetActive(true);
        for (int i = 0; i < _wall.GetComponentsInChildren<GoWall>().Length; i++)
        {
            Destroy(_wall.GetComponentsInChildren<GoWall>()[i].gameObject);
        }
        
    }
}
