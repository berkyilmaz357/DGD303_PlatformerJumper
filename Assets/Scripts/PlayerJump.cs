using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float ziplamaGucu = 10f; // Z�plama g�c�
    private Rigidbody rb; // Karakterin Rigidbody bile�eni
    private bool yereDustu = true; // Yere d���p d��medi�ini kontrol etmek i�in flag

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Yere d��t���nde ve "space" tu�una bas�ld���nda Zipla fonksiyonunu �a��r
        if (Input.GetKeyDown(KeyCode.Space) && yereDustu)
        {
            Zipla();
        }
    }

    void Zipla()
    {
        // Karaktere yukar� do�ru kuvvet uygula
        rb.velocity = new Vector3(rb.velocity.x, ziplamaGucu, rb.velocity.z);
        yereDustu = false; // Z�plad�ktan sonra karakterin havada oldu�unu belirt
    }

    void OnCollisionEnter(Collision collision)
    {
        // Karakter yere d��t���nde flag'i true yap
        if (collision.gameObject.CompareTag("Ground"))
        {
            yereDustu = true;
        }
    }
}
