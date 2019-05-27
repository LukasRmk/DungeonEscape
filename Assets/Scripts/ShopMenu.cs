using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public void BuyHealth()
    {
        if(GameVariables.coinAmount >= 3)
        {
            GameVariables.coinAmount = GameVariables.coinAmount - 3;
            GameVariables.healthDouble = true;
            Debug.Log("Player bought double health power-up");
        }
    }

    public void BuyFreeze()
    {
        if (GameVariables.coinAmount >= 3)
        {
            GameVariables.coinAmount = GameVariables.coinAmount - 3;
            GameVariables.canFreeze = true;
            Debug.Log("Player bought freeze power-up");
        }
    }
}
