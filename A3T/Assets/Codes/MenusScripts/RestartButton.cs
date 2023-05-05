using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;

    
    public void Restart()
    {
      transform.position = SpawnPoint.position;
    }

   
}
