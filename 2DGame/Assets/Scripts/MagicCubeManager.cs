using UnityEngine;

public class MagicCubeManager : MonoBehaviour
{
    [Header("魔術方塊")]
    public RectTransform[] magicCibes;
    [Header("畫布")]
    public Transform canvas;

    private int indexCurrent;
    private int indexNext = -1;
    private RectTransform cubeCurrent;

    public static float speed = 1;
    public static float controlHorizontal = 150;
    public static float controlSpace = 200;

    private void Awake()
    {
        RandomMagicCube();
    }

    private void RandomMagicCube()
    {
        if (indexNext == -1) indexCurrent = Random.Range(0, magicCibes.Length);
        else indexCurrent = indexNext;

        cubeCurrent = Instantiate(magicCibes[indexCurrent], canvas).GetComponent<RectTransform>();

        cubeCurrent.anchoredPosition = new Vector2(0, 400);

        indexNext = Random.Range(0, magicCibes.Length);
    }
}
