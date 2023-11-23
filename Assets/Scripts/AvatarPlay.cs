using System.Collections;
using UnityEngine;

public class AvatarPlay : MonoBehaviour
{

    public GameObject Avatar;
    public bool canJump;


    private void Start()
    {
        canJump = true;
    }

    IEnumerator jump()
    {
        canJump = false;
        Avatar.GetComponent<Animator>().Play("AvatarPulaPula");
        yield return new WaitForSeconds(0.3f);


        canJump = true;

        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Space") && canJump == true)
        {

            canJump = false;

            // Avatar.GetComponent<Animator>().Play("AvatarPulaPula");

            StartCoroutine(jump());

        }
    }
}
