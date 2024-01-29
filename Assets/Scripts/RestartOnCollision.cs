using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // �arp��ma ger�ekle�ti�inde, �arp��an nesnenin "Player" tag'ine sahip olup olmad���n� kontrol et
        if (collision.gameObject.CompareTag("Player"))
        {
            // E�er �arp��an nesne "Player" tag'ine sahipse, sahneyi yeniden ba�lat
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
