using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class pickingUp : MonoBehaviour
{
    // Start is called before the first frame update

    public bool inRange;
    public KeyCode interactionKey = KeyCode.E;
    public UnityEvent interactionEvent;
    public GameObject pickedItem;
    public AudioSource pickingSound;

    // Update is called once per frame
    void Update()
    {
        if (inRange)
        {

            if (Input.GetKeyDown(interactionKey))
            {
                Debug.Log("Wcisnieto przycisk interakcji");
                data.haveBow = true;
                if (data.haveBow)
                {
                    Debug.Log("Quest taken");
                    pickingSound.Play();
                    Destroy(pickedItem);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(interactionKey))
            {
                Debug.Log("Wcisnieto przycisk interakcji ale poza strefa :P");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
        Debug.Log("w zasiegu");


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        Debug.Log("Poza zasiegiem :(((");

    }

}
