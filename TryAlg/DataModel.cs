using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryAlg
{
    //使用者的model
    public class UserInfo
    {
        public string Name { get; set; }
        public int Gender { get; set; } = 0;
        public int Age { get; set; }
        public string Occupation { get; set; }
        public string Job { get; set; }
        public string Area { get; set; }
        public string Status { get; set; }
        public int DoseCount { get; set; }
        public Dictionary<string, bool> VaccineWilling { get; set; }
    }

    //演算法參數的model
    public class AlgorithmParameter
    {
        public int age_targetAgeButtom { get; set; }
        public int age_targetAgeTop { get; set; }
        public int age_direction { get; set; }
        public Dictionary<string,double> job_dict { get; set; }
        public Dictionary<string,double> state_dict { get; set; }
        public string area_area { get; set; }
        public int ordinal_dict { get; set; }
    }

    public class CityModel
    {
        //地區的結構(創建地區)
        public static List<string[]> CreateCityModel()
        {
            string[] listNorth = { "台北", "新北", "基隆" };
            string[] listSouth = { "台南", "高雄", "屏東" };
            List<string[]> Area = new List<string[]> { listNorth, listSouth };

            return Area;
        }
    }

}