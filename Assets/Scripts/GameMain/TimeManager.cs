using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    private float slowDownFactor = 0.05f;

   public IEnumerator SlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.2f;
        yield return new WaitForSeconds(.05f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
      
    }
}
