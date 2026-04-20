using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public Animator playerAnim;
    private string animAtual;

    public void Anima(string animName)
    {
        Debug.Log("Tentando animar: " + animName + " | atual: " + animAtual);
        if (playerAnim != null && animAtual != animName)
        {
            animAtual = animName;
            playerAnim.Play(animName);
            Debug.Log("Play chamado: " + animName);
        }
    }
}