using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TempMoniter
{
    /// <summary>
    /// 数据处理服务，包括数据转换和数据存储
    /// </summary>
    class DataServer
    {
        TempData Data = new TempData();//实体化数据类

        public TempData DataAnaly(string DataStr)
        {
            string[] DataArray = DataStr.Split('#');//拆分字符串并且序列化
            Data.Line_1 = Convert.ToDouble(DataArray[0]);
            Data.Line_2 = Convert.ToDouble(DataArray[1]);
            Data.Line_3 = Convert.ToDouble(DataArray[2]);
            Data.Line_4 = Convert.ToDouble(DataArray[3]);
            Data.Line_5 = Convert.ToDouble(DataArray[4]);
            Data.Line_6 = Convert.ToDouble(DataArray[5]);
            Data.Line_7 = Convert.ToDouble(DataArray[6]);
            Data.Line_8 = Convert.ToDouble(DataArray[7]);
            return Data;
        }

        public void SaveDate(TempData data)
        {
            string fileName = "数据\\"+DateTime.Now.ToString("yyyy-MM-dd") + "温度采集记录.txt";
            //string fileName1= "D:\\TestDir\\TestFile.txt";
            FileStream fs = new FileStream(@fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToLocalTime().ToString() + "\t\t" +
                data.Line_1.ToString() + "\t" +
                data.Line_2.ToString() + "\t" +
                data.Line_3.ToString() + "\t" +
                data.Line_4.ToString() + "\t" +
                data.Line_5.ToString() + "\t" +
                data.Line_6.ToString() + "\t" +
                data.Line_7.ToString() + "\t" +
                data.Line_8.ToString() + "\t");
            sw.Close();
            fs.Close();
        }

    }
}
