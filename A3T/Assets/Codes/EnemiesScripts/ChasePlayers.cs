using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayers : MonoBehaviour
{
    //[SerializeField] private AudioSource collectionSoundEffect;
    public Transform[] patrolPoints;
    public float velocidade;
    public int patrolDestination;

    void Update()
    {
        if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, velocidade * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                patrolDestination = 1;
            }
        }
        if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, velocidade * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                //collectionSoundEffect.Play();
                patrolDestination = 0;
            }
        }
    }
}
