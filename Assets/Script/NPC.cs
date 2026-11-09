using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private string npcName = "마을 주민";
    [SerializeField] private string massage = "마을에 온 것을 환영해";

    public string GetNPCName()
    {
        return npcName;
    }

    public string GetMassage()
    {
        return massage;
    }

    public string GetGuideText()
    {
        return "[E] " + npcName + "와 대화하기";
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
