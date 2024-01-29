using UnityEngine;

public class YildizDondur : MonoBehaviour
{
    public float donmeHizi = 5f; 

    void Update()
    {
        
        transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime);
    }
}
