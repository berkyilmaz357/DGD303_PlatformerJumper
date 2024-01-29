using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float ziplamaGucu = 10f; // Zýplama gücü
    private Rigidbody rb; // Karakterin Rigidbody bileþeni

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // "space" tuþuna basýldýðýnda Zipla fonksiyonunu çaðýr
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Zipla();
        }
    }

    void Zipla()
    {
        // Karaktere yukarý doðru kuvvet uygula
        rb.velocity = new Vector3(rb.velocity.x, ziplamaGucu, rb.velocity.z);
    }
}
