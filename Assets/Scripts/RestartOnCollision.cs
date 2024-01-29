using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Çarpýþma gerçekleþtiðinde, çarpýþan nesnenin "Player" tag'ine sahip olup olmadýðýný kontrol et
        if (collision.gameObject.CompareTag("Player"))
        {
            // Eðer çarpýþan nesne "Player" tag'ine sahipse, sahneyi yeniden baþlat
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
