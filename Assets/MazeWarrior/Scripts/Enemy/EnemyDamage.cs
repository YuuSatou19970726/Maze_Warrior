using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]
    private int damageAmount = 2;

    [SerializeField]
    private LayerMask playerLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere (transform.position, 0.1f, playerLayer);

        if (hits.Length > 0)
        {
            if (hits [0].gameObject.tag == MyTags.PLAYER_TAG)
            {
                hits [0].gameObject.GetComponent<PlayerHealth> ().ApplyDamage (damageAmount);
            }
        }
    }
}