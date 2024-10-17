using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Process : MonoBehaviour
{
    public enum State { New, Running, Waiting, Ready, Terminated }
    public State currentState;
    public Color newColor, runningColor, waitingColor, readyColor, terminatedColor;

    void Start()
    {
        Debug.Log("Process started");
        SetState(State.New);
    }

    public void SetState(State state)
    {
        Debug.Log("Setting state to: " + state.ToString());
        currentState = state;
        UpdateColor();  
    }

    private void UpdateColor()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr == null)
        {
            Debug.LogError("SpriteRenderer is null!"); 
            return;
        }

        switch (currentState)
        {
            case State.New:
                sr.color = newColor;
                Debug.Log("Color set to: New Color");  
                break;
            case State.Running:
                sr.color = runningColor;
                break;
            case State.Waiting:
                sr.color = waitingColor;
                break;
            case State.Ready:
                sr.color = readyColor;
                break;
            case State.Terminated:
                sr.color = terminatedColor;
                break;
        }
    }


    
}


