using UnityEngine;

public class ProcessManager : MonoBehaviour
{
    public Process selectedProcess;

    public void SetRunning()
    {
        if (selectedProcess != null)
            selectedProcess.SetState(Process.State.Running);
    }

    public void SetWaiting()
    {
        if (selectedProcess != null)
            selectedProcess.SetState(Process.State.Waiting);
    }

    public void SetTerminated()
    {
        if (selectedProcess != null)
            selectedProcess.SetState(Process.State.Terminated);
    }

}
