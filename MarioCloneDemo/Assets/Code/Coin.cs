using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UIManager.instance.UpdateCoinText(coinValue);
        Destroy(gameObject);
    }
}
