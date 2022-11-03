using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Record : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _record, _score;
    void Start()
    {
        _record.text = PlayerPrefs.GetInt("Score").ToString();
        _score.text = PlayerPrefs.GetInt("Score1").ToString();
    }
}
