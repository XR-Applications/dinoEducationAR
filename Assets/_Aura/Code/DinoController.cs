using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class responds to screen taps
/// and to camera track events
/// as well as instantiation events
/// </summary>
public abstract class DinoController : MonoBehaviour
{
    [SerializeField] protected GameObject m_InfoUI;
    [SerializeField] protected Animator m_DinoAnimator;
    [SerializeField] protected DinoInfoUI m_DinoInfo;
    protected virtual void Start()
    {
        m_InfoUI.SetActive(false);
    }
    protected virtual void OnMouseDown()
    {
        m_InfoUI.SetActive(!m_InfoUI.activeSelf);   
    }
}
