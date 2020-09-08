using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class HealthScript : MonoBehaviour
{
    //всего хитпоитов
    public int hp = 1;
    //враг или игрок?
    public bool isEnemy = true;

    public AudioClip BoyUh;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //наносим урон и проверяем должен ли объект быть уничтоженым
    public void Damage (int damageCount)
    {
        hp -= damageCount;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //это выстрел?
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            //избегайте дружественного огня
            if (shot.isEnemyShot != isEnemy)
            {
                audioSource.PlayOneShot(BoyUh, 0.7F);
                Damage(shot.damage);
                //уничтожить выстрел
                Destroy(shot.gameObject);
                GameObject go = GameObject.FindGameObjectWithTag("Player");
               
                //GetComponent<AudioSource>().PlayOneShot(BoyUh);
                //GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
                //enemy.GetComponent<AudioSource>().PlayOneShot(BoyUh);
                //audio.PlayOneShot(audio.clip);
                go.GetComponent<ScoreScript>().AddScore();
                
              //  ScoreScript.scoreValue += 10;
                
            }
        }

        Death death = otherCollider.gameObject.GetComponent<Death>();
        if (death != null)
        {
            Destroy(gameObject);
        }
    }
}
