using DG.Tweening;
using UnityEngine;

public class Rotate_Image : MonoBehaviour
{
    private Tweener tween;

    public GameObject BG;

    private void OnEnable()
    {
        StartAnimRight();
    }

    private void StartAnimRight()
    {
      //  tween = BG.transform.DOLocalRotateQuaternion(150f, 60f).OnComplete(StartAnimLeft);
    }

    private void StartAnimLeft()
    {
        tween = BG.transform.DOLocalMoveX(160f, 60f).OnComplete(StartAnimRight);
    }
}
