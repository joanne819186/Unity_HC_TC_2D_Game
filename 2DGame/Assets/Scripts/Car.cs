using UnityEngine;

public class Car : MonoBehaviour
{
    // 單行註解 (說明)
    // 數值 = 欄位 Field
    // 語法：
    // 修飾詞 類型 名稱 (指定 值)；

    // 四大類型 - Unity 常用
    // 整　數 int：沒有小數點的數值，例：０、１、－９９
    // 浮點數 float：有小數點的數值，例：０．１、０．１２３４５６、－１．９
    // 字　串 string：ＢＭＷ、賓士、＠＃＄
    // 布林值 bool：有 true、沒有 false

    // 指定符號 =

    // 私人 private 不會顯示在屬性面板上 - 預設值
    // 公開 public  會顯示在屬性面板上


    // 欄位的屬性
    // 標題 Header  - 字串
    // 提示 Tooltip - 字串
    // 範圍 Range
    [Header("這是車子的尺寸")]
    public int size = 100;
    [Tooltip("這是車子的重量，單位是噸。")]
    public float weight = 1.5f;
    [Header("品牌")]
    [Tooltip("這是車子的品牌")]
    public string brand = "BMW";
    [Header("是否有天窗"), Tooltip("這台車有沒有天窗")]
    public bool hasWindow = true;
}
