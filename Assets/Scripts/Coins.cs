using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        GameVariables.coinAmount = GameVariables.coinAmount + 1;
        Destroy(gameObject);
    }
}
