using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PointFucker : MonoBehaviour{
[SerializeField]
TMP_Text pointText;
    void Start(){
        int points=ShipController.points;
        pointText.text="Score: "+points.ToString();
        
    }
}
