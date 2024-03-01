using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    private int damageAmount = 2;

    [SerializeField]
    private LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere (transform.position, 0.7f, enemyLayer);

        if (hits.Length > 0)
        {
            if (hits [0].gameObject.tag == MyTags.ENEMY_TAG)
            {
                hits [0].gameObject.GetComponent<EnemyHealth> ().ApplyDamage (damageAmount);
            }
        }
    }
}
