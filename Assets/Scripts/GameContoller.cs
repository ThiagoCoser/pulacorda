using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class GameContoller : MonoBehaviour
{


    public int Score = 0;
    public GameObject Corda;
    public GameObject CordaCollider;

    public GameObject IniciarTxt;
    public GameObject ScoreTxt;
    public GameObject GameOverTxt;
    public GameObject ContadorTxt;


    public bool podeIniciar;


    public GameObject changeAvatarScript;

    void Start()
    {
        podeIniciar = true;
    }

    IEnumerator GameStart()
    {


        changeAvatarScript.GetComponent<changeAvatar>().TrocarTexturaAleatoria();


        podeIniciar = false;
        GameOverTxt.SetActive(false);

        IniciarTxt.SetActive(false);

        ContadorTxt.SetActive(true);
        Corda.GetComponent<Animator>().enabled = true;

        Corda.GetComponent<Animator>().Play("Idle");

        ContadorTxt.GetComponent<TextMeshProUGUI>().text = "3";
        yield return new WaitForSeconds(1);
        ContadorTxt.GetComponent<TextMeshProUGUI>().text = "2";
        yield return new WaitForSeconds(1);
        ContadorTxt.GetComponent<TextMeshProUGUI>().text = "1";
        yield return new WaitForSeconds(1);
        ContadorTxt.GetComponent<TextMeshProUGUI>().text = "PULA";
        yield return new WaitForSeconds(1);
        Corda.GetComponent<Animator>().enabled = true;
        ContadorTxt.SetActive(false);
        Corda.GetComponent<Animator>().Play("CordaBate");
        CordaCollider.SetActive(true);



        yield return null;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Space") && podeIniciar == true)
        {

            StartCoroutine(GameStart());

        }
    }
}
