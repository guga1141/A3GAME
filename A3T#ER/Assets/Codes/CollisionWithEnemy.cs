using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CollisionWithEnemy : MonoBehaviour
{
    public TextMeshProUGUI winTexto;
    public TextMeshProUGUI restartTexto;
    public TextMeshProUGUI exitTexto;

    [SerializeField] private AudioSource coinSoundEffect;

    //[SerializeField] private AudioSource SoundEffect;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Damage");
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            coinSoundEffect.Play();
        }

        if (other.gameObject.CompareTag("Win"))
        {
            winTexto.gameObject.SetActive(true);            
            restartTexto.gameObject.SetActive(true);
            exitTexto.gameObject.SetActive(true);
            
        }
    }
} 

    

