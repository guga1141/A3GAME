using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public float lar = 0f;
    public float alt = 0f;

    private void Update()
    {
        transform.position = new Vector3(player.position.x + lar, player.position.y + alt, -10); // Camera follows the player but 6 to the right
    }
}
