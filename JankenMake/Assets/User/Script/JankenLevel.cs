using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerScript;
using Photon.Pun;

public class JankenLevel : MonoBehaviourPunCallbacks
{
    Player player,opponent;
    public Text[] Text;

    void Start()
    {
        player = new Player();

    }

    void Update()
    {
        
    }

    public void LevelButton(string kind)
    {
        switch (kind) {
            case "CUP":player.choki.Level++; break;
            case "CDOWN": player.choki.Level--; break;
            case "GUP": player.gu.Level++; break;
            case "GDOWN": player.gu.Level--; break;
            case "PUP": player.pa.Level++; break;
            case "PDOWN": player.pa.Level++; break;
        }
        Text[0].text = player.gu.Level.ToString();
        Text[1].text = player.choki.Level.ToString();
        Text[2].text = player.pa.Level.ToString();
    }
  
}
