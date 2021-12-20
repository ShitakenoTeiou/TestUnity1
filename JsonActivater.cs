using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonActivater : MonoBehaviour
{
    public SaveData.SampleMapData SMD = new SaveData.SampleMapData();
    public int[] celleffectNumArr = new int[136]
                               {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                0, 0,10,23,10,10,10, 0,60,10,10,40, 0, 0, 0, 0, 0,
                                0, 0,40, 0, 0, 0,10, 0, 0, 0, 0,10, 0, 0, 0, 0, 0,
                                0, 0,10, 0,10,10,25,10,10, 0, 0,32, 0, 0, 0, 0, 0,
                                0, 0,32, 0,40, 0, 0, 0,40, 0, 0,25, 0, 0, 0, 0, 0,
                                0, 0,10, 0,10, 0, 0, 0,25, 0, 0,40, 0, 0, 0, 0, 0,
                               50,10,10,33,10,40,10,25,10,10,33,10, 0, 0, 0, 0, 0};
    public SaveData.Junction[] junctionArr = new SaveData.Junction[7];
    public List<int>[] junctionNextjunction = new List<int>[100];
    public List<int>[] junctionHoldingCell = new List<int>[100];
    public List<int>[] junctionHoldingCellCharacter = new List<int>[100];
    public int junctionCount;


    public void Start()
    {
        SetMapData();
        for (int i = 0; i < 6; i++)
        {
            SMD.junctionList.Add(junctionArr[i]);
        }

        Debug.Log(JsonUtility.ToJson(SMD));


    }

    public void SetMapData()
    {
        junctionCount = 7;

        junctionNextjunction[0] = new List<int>() { 1, 2 };
        junctionNextjunction[1] = new List<int>() { 4 };
        junctionNextjunction[2] = new List<int>() { 3, 5 };
        junctionNextjunction[3] = new List<int>() { 4 };
        junctionNextjunction[4] = new List<int>() { 6 };
        junctionNextjunction[5] = new List<int>() { 6 };
        junctionNextjunction[6] = new List<int>() { 0 };

        junctionHoldingCell[0] = new List<int>() { 119, 120, 121 };
        junctionHoldingCell[1] = new List<int>() { 104, 87, 70, 53, 36, 37, 38, 39, 40, 57 };
        junctionHoldingCell[2] = new List<int>() { 122, 123 };
        junctionHoldingCell[3] = new List<int>() { 106, 89, 72, 73 };
        junctionHoldingCell[4] = new List<int>() { 74, 75, 76, 93, 110 };
        junctionHoldingCell[5] = new List<int>() { 123, 124, 125 };
        junctionHoldingCell[6] = new List<int>() { 127, 128, 129, 130, 113, 96, 79, 62, 45, 44, 43, 42 };

        for (int i = 0; i < 7; i++)
        {
            junctionHoldingCellCharacter[i] = new List<int>();
            for (int j = 0; j < junctionHoldingCell[i].Count; j++)
            {
                junctionHoldingCellCharacter[i].Add(celleffectNumArr[junctionHoldingCell[i][j]]);
            }
            
        }

        for (int i = 0; i < 7; i++)
        {
            junctionArr[i] = new SaveData.Junction(junctionHoldingCell[i], junctionHoldingCell[i], junctionHoldingCellCharacter[i]);
        }
    }
    //void Start()
    //{


    //    //Intojson.aaa a = new Intojson.aaa();
    //    //a.ValueIntoArr();
    //    //Debug.Log(JsonUtility.ToJson(a));
    //}
}
