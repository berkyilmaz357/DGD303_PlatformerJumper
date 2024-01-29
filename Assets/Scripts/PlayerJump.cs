using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float ziplamaGucu = 10f; // Zýplama gücü
    private Rigidbody rb; // Karakterin Rigidbody bileþeni
    private bool yereDustu = true; // Yere düþüp düþmediðini kontrol etmek için flag

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Yere düþtüðünde ve "space" tuþuna basýldýðýnda Zipla fonksiyonunu çaðýr
        if (Input.GetKeyDown(KeyCode.Space) && yereDustu)
        {
            Zipla();
        }
    }

    void Zipla()
    {
        // Karaktere yukarý doðru kuvvet uygula
        rb.velocity = new Vector3(rb.velocity.x, ziplamaGucu, rb.velocity.z);
        yereDustu = false; // Zýpladýktan sonra karakterin havada olduðunu belirt
    }

    void OnCollisionEnter(Collision collision)
    {
        // Karakter yere düþtüðünde flag'i true yap
        if (collision.gameObject.CompareTag("Ground"))
        {
            yereDustu = true;
        }
    }
}
