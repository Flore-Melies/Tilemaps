﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectiblesCollecter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMesh;
    
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            counter++;
            textMesh.text = counter.ToString();
            Destroy(other.gameObject);
        }
    }
}
