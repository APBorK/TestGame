using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Point")
        {
            Destroy(col.gameObject.GetComponentInParent<GoWall>().gameObject);
        }
    }
}
