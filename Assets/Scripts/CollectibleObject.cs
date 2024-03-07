using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleObject : MonoBehaviour
{
    public int healingAmount = 10;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject + " enters healing zone");
        if (collision.tag == "Player")
        {
            RubyController player = collision.GetComponent<RubyController>();
            if (player.currentHP < player.maxHP)
            {
                player.ChangeHP(healingAmount);
                Destroy(this.gameObject);
            }

        }
    }
}
