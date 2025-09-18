using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogDisable : MonoBehaviour
{
    private bool fogState;

    private void OnPreRender()
    {
        fogState = RenderSettings.fog;
        RenderSettings.fog = false;
    }

    private void OnPostRender()
    {
        RenderSettings.fog = fogState;
    }




}
