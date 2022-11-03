using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnWall : MonoBehaviour
{
    [SerializeField] private GameObject _wall;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private float _max, _min;
    private float _speed;

    private void OnEnable()
    {
        if (_speed > 0)
        {
            PlayerPrefs.SetFloat("Speed",_speed);
        }
        else
        {
            _speed = PlayerPrefs.GetFloat("Speed");
        }
        var _gameObject = Instantiate(_wall,_startPoint);
        _gameObject.GetComponent<GoWall>().Speed = _speed;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Point" && col.GetComponent<NextWall>())
        {
            Destroy(col.GetComponent<NextWall>());
            var _gameObject = Instantiate(_wall,_startPoint);
            _gameObject.GetComponent<GoWall>().Speed = _speed;
            _gameObject.transform.position = new Vector3(_gameObject.transform.position.x,Random.Range(_min, _max));
        }
    }

    public void Speed(float speed)
    {
        _speed = speed;
    }
}
