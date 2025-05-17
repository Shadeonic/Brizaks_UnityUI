using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    //Daedalus bruņas
    public GameObject DaedHelm;
    public GameObject DaedPlate;
    public GameObject DaedLeg;
    //God bruņas
    public GameObject GodHelm;
    public GameObject GodPlate;
    public GameObject GodLeg;
    //StarDust bruņas
    public GameObject StarHelm;
    public GameObject StarPlate;
    public GameObject StarLeg;
    //Zobeņi
    public GameObject Sword1;
    public GameObject Sword2;
    public GameObject Sword3;

    [HideInInspector]
    public Vector2 DaedHelmPos;
    [HideInInspector]
    public Vector2 DaedPlatePos;
    [HideInInspector]
    public Vector2 DaedLegPos;
    [HideInInspector]
    public Vector2 GodHelmPos;
    [HideInInspector]
    public Vector2 GodPlatePos;
    [HideInInspector]
    public Vector2 GodLegPos;
    [HideInInspector]
    public Vector2 StarHelmPos;
    [HideInInspector]
    public Vector2 StarPlatePos;
    [HideInInspector]
    public Vector2 StarLegPos;
    [HideInInspector]
    public Vector2 Sword1Pos;
    [HideInInspector]
    public Vector2 Sword2Pos;
    [HideInInspector]
    public Vector2 Sword3Pos;

    public GameObject lastDragged = null;

}
