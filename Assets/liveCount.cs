using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liveCount : MonoBehaviour
{
    Text liveText;
    public void updateLiveText( int countLive )
    {
        countLive = countLive + 1;
    }
}
