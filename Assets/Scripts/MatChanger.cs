using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class MatChanger : MonoBehaviour
{
    [Header("Wall Materials")]
    public Material[] WallReferance;
    public Material[] WallAdobeFirefly;
    public Material[] WallLayerAI;
    public Material[] WallOrbofi;
    public Material[] WallPolycam;

    [Header("Floor Materials")]
    public Material[] FloorReferance;
    public Material[] FloorAdobeFirefly;
    public Material[] FloorLayerAI;
    public Material[] FloorOrbofi;
    public Material[] FloorPolycam;

    [Header("Text")]
    public string[] EngineTitle;
    public TextMeshProUGUI EngineUI;
    public string[] RoomTitle; 
    public TextMeshProUGUI RoomUI;

    [Header("Walls")]
    public Renderer Floor;
    public Renderer[] Walls;

    [Header("Settings")]
    public Material WallActiveMat;
    public Material FloorActiveMat;
    public int i;
    public int Engine;

    [Header("Buttons")]
    public Button NextRoomButton; 
    public Button PrevRoomButton;
    public Button NextEngineButton; 
    public Button PrevEngineButton;
    // Start is called before the first frame update
    void Start()
    {
        FloorActiveMat = FloorReferance[0];
        WallActiveMat = WallReferance[0];
        Floor.material = FloorActiveMat;
        EngineUI.text = EngineTitle[0];
        RoomUI.text = RoomTitle[0];
        for (int w = 0; w < Walls.Length; w++)
        {
            Walls[w].material = WallActiveMat;
        }
        NextRoomButton.onClick.AddListener(NextRoom);
        PrevRoomButton.onClick.AddListener(PreviousRoom); 
        NextEngineButton.onClick.AddListener(NextEngine);
        PrevEngineButton.onClick.AddListener(PreviousEngine); 
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void NextRoom() 
    {
        if (i < 5)
            { i++; }
        if (i == 5 )
        {
            i = 0;
        }

        MatSelect();
    }
    void PreviousRoom() {i--; MatSelect(); }
    void NextEngine() {
        if (Engine < 5) 
        { 
            Engine++; 
        }
        if ( Engine == 5)
        {
            Engine = 0; 
            
        }
        MatSelect(); }
    void PreviousEngine() {
        if (Engine > -1)
        { Engine--; }
        if (Engine == -1)
        { Engine = 4; }
        MatSelect(); }
    void MatSelect() 
    {
        //Ref Engine 
        if (Engine ==0)
        {
            FloorActiveMat = FloorReferance[i];
            WallActiveMat = WallReferance[i];
            EngineUI.text = EngineTitle[0];
        }
        if (Engine == 1)
        {
            FloorActiveMat = FloorAdobeFirefly[i];
            WallActiveMat = WallAdobeFirefly[i];
            EngineUI.text = EngineTitle[1];
        }
        if (Engine == 2)
        {
            FloorActiveMat = FloorLayerAI[i];
            WallActiveMat = WallLayerAI[i];
            EngineUI.text = EngineTitle[2];
        }
        if (Engine == 3)
        {
            FloorActiveMat = FloorOrbofi[i];
            WallActiveMat = WallOrbofi[i];
            EngineUI.text = EngineTitle[3];
        }
        if (Engine == 4)
        {
            FloorActiveMat = FloorPolycam[i];
            WallActiveMat = WallPolycam[i];
            EngineUI.text = EngineTitle[4];
        }

        Floor.material = FloorActiveMat; 
        for (int w = 0; w < Walls.Length; w++)
        {
            Walls[w].material = WallActiveMat;
        }
        
        RoomUI.text = RoomTitle[i];

    }
}
