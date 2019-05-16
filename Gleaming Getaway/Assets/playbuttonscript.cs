﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playbuttonscript : MonoBehaviour
{
    public AudioSource mySource;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnMouseDown()
	{
        mySource.Play();
        StartCoroutine(PlayGame());
	}

    IEnumerator PlayGame(){
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
