using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField]
    private int health = 100;
    private Enemy enemyScript;

    private Animator anim;

    void Awake()
    {
        enemyScript = GetComponent<Enemy> ();
        anim = GetComponent<Animator> ();
    }

    public void ApplyDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0)
        {
            health = 0;
        }

        if (health == 0)
        {
            enemyScript.enabled = false;
            anim.SetTrigger (MyTags.DEAD_TRIGGER);

            Invoke (nameof(DeactivateEnemy), 3f);
        }
    }

    void DeactivateEnemy()
    {
        gameObject.SetActive (false);
    }
}
