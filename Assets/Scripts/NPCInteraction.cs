using UnityEngine;

public class NCPINInteraction : MonoBehaviour
{
    public GameObject abcObject; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            abcObject.SetActive(true);
        }
    }
}
