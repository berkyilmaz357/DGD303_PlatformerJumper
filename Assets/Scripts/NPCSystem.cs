using UnityEngine;
using UnityEngine.UI;

public class NPCSystem : MonoBehaviour
{
    bool player_detection = false;




     void Update()
    {
        if(player_detection && Input.GetKeyDown(KeyCode.F))
        {
            print("dialoge started");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "PlayerBody")
        {
            player_detection = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }

















}
