using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float ziplamaGucu = 10f; // Z�plama g�c�
    private Rigidbody rb; // Karakterin Rigidbody bile�eni

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // "space" tu�una bas�ld���nda Zipla fonksiyonunu �a��r
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Zipla();
        }
    }

    void Zipla()
    {
        // Karaktere yukar� do�ru kuvvet uygula
        rb.velocity = new Vector3(rb.velocity.x, ziplamaGucu, rb.velocity.z);
    }
}
