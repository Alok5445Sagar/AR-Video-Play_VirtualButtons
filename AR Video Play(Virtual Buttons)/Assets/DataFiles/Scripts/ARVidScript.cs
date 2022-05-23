
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARVidScript : MonoBehaviour
{
    public GameObject firstgo, secondgo, thirdgo;
    public VirtualButtonBehaviour FirstVbtn, SecondVbtn, ThirdVbtn;
    // Start is called before the first frame update
    void Start()
    {
      FirstVbtn.RegisterOnButtonPressed(OnButtonPressed);
      FirstVbtn.RegisterOnButtonReleased(OnButtonReleased);

      SecondVbtn.RegisterOnButtonPressed(OnButtonPressed);
      SecondVbtn.RegisterOnButtonReleased(OnButtonReleased);

      ThirdVbtn.RegisterOnButtonPressed(OnButtonPressed);
      ThirdVbtn.RegisterOnButtonReleased(OnButtonReleased);

      firstgo.SetActive(false);
      secondgo.SetActive(false);
      thirdgo.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        if(vb.VirtualButtonName == "FirstVbtn"){
          Debug.Log("First button pressed");
          firstgo.SetActive(true);
          secondgo.SetActive(false);
          thirdgo.SetActive(false);  
        }

        else if(vb.VirtualButtonName == "SecondVbtn"){
             Debug.Log("Second button pressed");
                firstgo.SetActive(false);
                secondgo.SetActive(true);
                thirdgo.SetActive(false);
        }

        else if(vb.VirtualButtonName == "ThirdVbtn"){
             Debug.Log("Third button pressed");
                firstgo.SetActive(false);
                secondgo.SetActive(false);
                thirdgo.SetActive(true);
        }

        else{
             Debug.Log("No button pressed");
        }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){

     Debug.Log("Virtual button pressed");

    }
    
}
