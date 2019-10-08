﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


//public string dialogueBlock;

public class DialogueScript : MonoBehaviour
{
    private bool spoken = false;
    public Flowchart flowchart;
    public string dialogue;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            if (!spoken)
            {
                flowchart.ExecuteBlock(dialogue);
                spoken = true;
            }
        }
    }
}
