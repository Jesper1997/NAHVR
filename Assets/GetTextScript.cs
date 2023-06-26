using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class GetTextScript : MonoBehaviour
{
    public GameObject Todolist;
    private ToDoListing ToDoListing;
    public int todolist_index1 = 1;
    public int todolist_index2 = 2;
    public AudioClip ringtone;
    public AudioClip phonecallaudio1;
    public AudioClip phonecallaudio2;
    public AudioSource phoneSpeaker;
    bool phonecall1 = false;
    bool phonecall2 = false;
    int phonecall = 0;
    // Start is called before the first frame update
    void Start()
    {
        ToDoListing = Todolist.GetComponent<ToDoListing>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((ToDoListing.list[todolist_index1].Description.Contains("<s>")) && (phonecall != 1))
        {
            //Execution methode
            Debug.Log(ToDoListing.list[todolist_index1].Description);
            phoneSpeaker.loop = true;
            phonecall = 1;
            phoneSpeaker.clip = ringtone;
            phoneSpeaker.Play();
        }

        if ((ToDoListing.list[todolist_index2].Description.Contains("<s>")) && (phonecall != 2))
        {
            //Execution methode
            Debug.Log(ToDoListing.list[todolist_index2].Description);
            phoneSpeaker.loop = true;
            phonecall = 2;
            phoneSpeaker.clip = ringtone;
            phoneSpeaker.Play();
        }
    }

    public void Playmessage()
    {
        if ((phonecall == 1) && (!phonecall1))
        {
            phoneSpeaker.clip = phonecallaudio1;
            phoneSpeaker.loop = false;
            phoneSpeaker.Play();
            phonecall1 = true;
        }
        if ((phonecall == 2) && (!phonecall2))
        {
            phoneSpeaker.clip = phonecallaudio2;
            phoneSpeaker.loop = false;
            phoneSpeaker.Play();
            phonecall2 = true;
        }
    }
}

