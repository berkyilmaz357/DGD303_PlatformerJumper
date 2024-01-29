using UnityEngine;

public class YildizDondur : MonoBehaviour
{
    public float donmeHizi = 5f; // Dönme hýzý (istediðiniz hýza göre ayarlayýn)

    void Update()
    {
        // Z ekseni etrafýnda dönme
        transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime);
    }
}
