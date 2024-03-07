using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public int damageAmount;
    void OnTriggerEnter2D(Collider2D collision)
    { 
        print(collision.gameObject + " enters damage zone");
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            RubyController player = collision.GetComponent<RubyController>();
            player.ChangeHP(-damageAmount);
        }
    }
}
