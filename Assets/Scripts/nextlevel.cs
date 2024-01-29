using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "y�ld�z" tag'ine sahip obje ile temas etti mi kontrol et
        if (other.CompareTag("Player"))
        {
            // Sonraki sahneyi y�kleyerek devam et
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
