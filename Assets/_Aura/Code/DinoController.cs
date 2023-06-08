using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class responds to screen taps
/// and to camera track events
/// as well as instantiation events
/// </summary>
public class DinoController : MonoBehaviour
{
    [SerializeField] GameObject m_InfoUI;
    [SerializeField] Animator m_DinoAnimator;
    private void Start()
    {
        m_InfoUI.SetActive(false);
    }
    private void OnMouseDown()
    {
        m_InfoUI.SetActive(!m_InfoUI.activeSelf);   
    }
}
