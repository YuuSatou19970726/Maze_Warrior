using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int health = 100;
    Player playerScript;

    private Animator anim;

    void Awake()
    {
        playerScript = GetComponent<Player> ();
        anim = GetComponent<Animator> ();
    }

    void Start()
    {
        GameplayController.instance.DisplayHealth (health);
    }

    public void ApplyDamage(int damageAmount)
    {
        health -= damageAmount;

        if (health < 0)
        {
            health = 0;
        }

        // DISPLAY THE HEALTH VALUE
        GameplayController.instance.DisplayHealth (health);


        if (health == 0)
        {
            playerScript.enabled = false;
            anim.Play (MyTags.DEAD_ANIMATION);

            // CALL GAME OVER
            GameplayController.instance.isPlayerAlive = false;

            // GAMEOVER PANEL
            GameplayController.instance.GameOver ();
        }

    }

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == MyTags.COIN_TAG)
        {
            target.gameObject.SetActive (false);

            GameplayController.instance.CoinCollected ();
            SoundManager.instance.PlayCoinSound ();
        }
    }
}
