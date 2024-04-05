using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckObjectTag : MonoBehaviour
{
    public GameObject inventory;
    public GameObject gameObject;
    public GameObject popUp1;
    public GameObject popUp2;
    public GameObject popUp3;
    public GameObject popUp4;
    public GameObject popUp5;
    public GameObject popUp6;
    public GameObject item;
    void Start(){
        inventory=GameObject.FindGameObjectWithTag("Inventory");
        gameObject=GameObject.FindGameObjectWithTag("GameObject");
        popUp1=GameObject.FindGameObjectWithTag("popUp1");
        popUp2=GameObject.FindGameObjectWithTag("popUp2");
        popUp3=GameObject.FindGameObjectWithTag("popUp3");
        popUp4=GameObject.FindGameObjectWithTag("popUp4");
        popUp5=GameObject.FindGameObjectWithTag("popUp5");
        popUp6=GameObject.FindGameObjectWithTag("popUp6");
        
    }
    public void PopUp1Show(){
        popUp1.transform.parent = inventory.transform;
        
        // popUp1.SetActive(true);
    }
    public void PopUp2Show(){
        
        popUp2.transform.parent = inventory.transform;
        
        // popUp1.SetActive(true);
    }
    public void PopUp3Show(){
       
        popUp3.transform.parent = inventory.transform;
       
        // popUp1.SetActive(true);
    }
    public void PopUp4Show(){
       
        popUp4.transform.parent = inventory.transform;
       
        // popUp1.SetActive(true);
    }
    public void PopUp5Show(){
        
        popUp5.transform.parent = inventory.transform;
        
        // popUp1.SetActive(true);
    }
    public void PopUp6Show(){
        
        popUp6.transform.parent = inventory.transform;
        // popUp1.SetActive(true);
    }

    public void PopUp1Close(){
        popUp1.transform.parent = gameObject.transform;
        
        

    }
    public void PopUp2Close(){
        popUp2.transform.parent = gameObject.transform;
    }
    public void PopUp3Close(){
        popUp3.transform.parent = gameObject.transform;
    }
    public void PopUp4Close(){
        popUp4.transform.parent = gameObject.transform;
    }
    public void PopUp5Close(){
        popUp5.transform.parent = gameObject.transform;
    }
    public void PopUp6Close(){
        popUp6.transform.parent = gameObject.transform;
    }



    
}
