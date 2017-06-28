using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour {

    public string Title;
    public string Text;
    public float DurationInTicks;

    private Tickable[] tickables;

    private void Start()
    {
        tickables = GetComponents<Tickable>();
    }

}
