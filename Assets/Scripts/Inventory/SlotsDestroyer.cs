using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsDestroyer : MonoBehaviour
{
public CheckObjectTag checkObjectTag;

void Start(){
    
}
public void DestroySlots(){
if (this.name=="ConfirmationPopUpItem1")
    {
        GameObject item1 = GameObject.FindGameObjectWithTag("CreatedItem1");
        Destroy(item1);
        checkObjectTag.PopUp1Close();
    }
if (this.name=="ConfirmationPopUpItem2")
    {
        GameObject item2 = GameObject.FindGameObjectWithTag("CreatedItem2");
        Destroy(item2);
        checkObjectTag.PopUp2Close();
    }
    if (this.name=="ConfirmationPopUpItem3")
    {
        GameObject item3 = GameObject.FindGameObjectWithTag("CreatedItem3");
        Destroy(item3);
        checkObjectTag.PopUp3Close();
    }
    if (this.name=="ConfirmationPopUpItem4")
    {
        GameObject item4 = GameObject.FindGameObjectWithTag("CreatedItem4");
        Destroy(item4);
        checkObjectTag.PopUp4Close();
    }
    if (this.name=="ConfirmationPopUpItem5")
    {
        GameObject item5 = GameObject.FindGameObjectWithTag("CreatedItem5");
        Destroy(item5);
        checkObjectTag.PopUp5Close();
    }
    if (this.name=="ConfirmationPopUpItem6")
    {
        GameObject item6 = GameObject.FindGameObjectWithTag("CreatedItem6");
        Destroy(item6);
        checkObjectTag.PopUp6Close();
    }

}
    
}
