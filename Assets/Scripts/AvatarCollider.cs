using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AvatarCollider : MonoBehaviour
{

    public GameObject AvatarPlayer;
    public GameObject GameOverTxt;
    public GameObject AvatarPlay;
    public GameObject Corda;
    public GameObject CordaCollider;
    public GameObject GameOverSND;

    IEnumerator GameOver()
    {
        GameOverSND.GetComponent<AudioSource>().Play();

        CordaCollider.SetActive(false);
        GameOverTxt.SetActive(true);
        Corda.GetComponent<Animator>().enabled = false;

        yield return new WaitForSeconds(3f);
        AvatarPlay.GetComponent<GameContoller>().podeIniciar = true;
        // GameOverTxt.SetActive(false);
        yield return null;
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Finish")
        {

            StartCoroutine(GameOver());

            // Debug.Log("Perdeu");
        }
        // if (other.tag == "Ground")
        // {
        //     AvatarPlayer.GetComponent<AvatarPlay>().canJump = true;
        // }

    }



}
