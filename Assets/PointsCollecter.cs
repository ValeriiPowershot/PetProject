using System;
using UnityEngine;

public class PointsCollecter : MonoBehaviour
{
    [SerializeField] private Score _score;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Tags.Point)) 
            _score.ScoreCount++;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(Tags.PlayZone))
        {
            Debug.Log("You just leave the play zone");
        }
    }
}
