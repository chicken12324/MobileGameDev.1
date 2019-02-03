using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
  
  public float movespeed = 10f;
  public bool enter = true;
	        var boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//move Object at keypress
	if (Input.GetKey(KeyCode.LeftArrow))	
	transform.Translate(Vector3.left * movespeed * Time.deltaTime);
	
		if (Input.GetKey(KeyCode.RightArrow))	
		transform.Translate(Vector3.right * movespeed * Time.deltaTime);
	
			if (Input.GetKey(KeyCode.UpArrow))	
			transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    
				if (Input.GetKey(KeyCode.DownArrow))	
				transform.Translate(-Vector3.forward * movespeed * Time.deltaTime);
	
	}
	 	 
    private void OnTriggerEnter(Collider other)
    {
        if (enter)
        {
            Debug.Log("entered");
        }
    }
}
