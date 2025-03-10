using System.Data;
using Oculus.Interaction.Samples;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;
using WindowsInput;
using UnityEngine.InputSystem;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Canvas;
    void Start()
    {
        StartCoroutine(Timer());
    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(10);
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1)) && Canvas.active)
        {
            delete();
        }
    }

    public void delete()
    {
        Canvas.SetActive(false);
    }
}
