﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POI : MonoBehaviour
{
    public string poiName;
    public TextAsset textScript;

    private void Start()
    {
        DialogueManager.instance.StartDialogue("Test");
    }

    public void StartDialogue()
    {
        DialogueManager.instance.StartDialogue(textScript);
    }
}
