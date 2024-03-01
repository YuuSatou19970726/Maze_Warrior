using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvents : MonoBehaviour
{
    [SerializeField]
    private GameObject player, playButton;

    void DeactivateGameObject()
    {
        player.SetActive (false);
        playButton.SetActive (false);
    }

    void ActiveGameObject()
    {
        player.SetActive (true);
        playButton.SetActive (true);
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {

        }
    }

    void OnTriggerExit(Collider target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {
            
        }
    }
}
