using UnityEngine;
public class LineDraw : MonoBehaviour
{
    [SerializeField] private LineRenderer _rend;
    [SerializeField] private Camera _cam;
    int posCount = 0;
    [SerializeField] float interval = 0.1f;

    private void Update()
    {


        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);
        SetPosition(mousePos);

    }

    private void SetPosition(Vector2 pos)
    {
        if (!PosCheck(pos)) return;
        {
            posCount++;
            _rend.positionCount = posCount;
            _rend.SetPosition(posCount - 1, pos);
        }
    }

    private bool PosCheck(Vector2 pos)
    {
        float distance;
        if (posCount == 0) return true;
        {
            distance = Vector2.Distance(_rend.GetPosition(posCount - 1), pos);
        }
        if (distance > interval)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}