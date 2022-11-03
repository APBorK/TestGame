using UnityEngine;

public class GoWall : MonoBehaviour
{
    public float Speed;
    
    void Update()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x,transform.position.y,0),new Vector3(-100,0,0), Speed * Time.deltaTime);
    }
}
