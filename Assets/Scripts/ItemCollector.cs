using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    private int keys = 0;
    [SerializeField] private TextMeshProUGUI counterText;
    [SerializeField] private AudioSource collectionSoundEffect;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            keys++;
            counterText.text = " x " + keys;
            
            Debug.Log("Keys :" + keys);
        }
    }

}
