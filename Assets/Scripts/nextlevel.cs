using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "yýldýz" tag'ine sahip obje ile temas etti mi kontrol et
        if (other.CompareTag("Player"))
        {
            // Sonraki sahneyi yükleyerek devam et
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
