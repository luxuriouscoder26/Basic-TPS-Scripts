using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderController : MonoBehaviour
{
    public HealthBarController healthBar;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            if (healthBar)
            {
                healthBar.OnTakeDamage(10);
            }
        }
    }
}
