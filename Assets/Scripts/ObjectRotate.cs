using UnityEngine;

public class YildizDondur : MonoBehaviour
{
    public float donmeHizi = 5f; // D�nme h�z� (istedi�iniz h�za g�re ayarlay�n)

    void Update()
    {
        // Z ekseni etraf�nda d�nme
        transform.Rotate(Vector3.forward, donmeHizi * Time.deltaTime);
    }
}
