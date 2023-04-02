using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class npcControll : MonoBehaviour
{
    [SerializeField] private GameObject talkingUI;
    [SerializeField] private Text nameText;
    [SerializeField] private Text conversationText;
    [SerializeField] private Image faceimage;

    [SerializeField] private string myname;
    [SerializeField] private string prompt;
    [SerializeField] private Sprite myface;
    

    bool startTalking = false;
    bool onoffTalking = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            startTalking = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            startTalking = false;
            talkingUI.SetActive(false);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interact")&& startTalking)
        {
            faceimage.sprite = myface;
            nameText.text = myname;
            conversationText.text = prompt;
            onoffTalking = !onoffTalking;
            talkingUI.SetActive(onoffTalking);
        }
    }


}
