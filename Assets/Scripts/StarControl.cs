using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class StarControl: MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI coinText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Yýldýz")
            
            Coin++;
            coinText.text = "Coin: " + Coin.ToString();
            
            Destroy(other.gameObject);
    }









}
