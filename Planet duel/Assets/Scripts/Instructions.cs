using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Instructions
{
    public static void DealDMG(int value)
    {
        //Console.WriteLine($"DMG dealt {value}");
        Debug.Log($"OOF {value}");
    }

    public static void GoBack(int value)
    {
        //Console.WriteLine($"Go back {value}");
        if(value > 0)
            Debug.Log($"Wooosh {value}");
        else
            Debug.Log($"Vrooom {-value}");
    }

    public static void Heal(int value)
    {
        //Console.WriteLine($"Go back {value}");
        Debug.Log($"Healed {value}");
    }
}
