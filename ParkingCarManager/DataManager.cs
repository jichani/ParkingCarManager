using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCarManager
{
    public class DataManager
    {
        // 로그 작성 부분 1.
        // ParkingCarManager.exe랑 같은 경로에 LogFolder라는 이름의 폴더가 없다면..
        public static void printLog (string contents)
        {
            DirectoryInfo di = new DirectoryInfo ("LogFolder");
            if (di.Exists == false) 
            {
                // 새로 만든다. mssql이 안되서 멈춤..
                di.Create();
            }
            // @"LogFolder\ParkingHistory.txt"
            // = "LogFolder\\ParkingHistory.txt"
            // true는 append 옵션을 true. 새로운 텍스트가 나오면 덮어쓰지 않고 뒤에다가 새로 이어붙인다.
            using (StreamWriter w = new StreamWriter(@"LogFolder\ParkingHistory.txt",true))
            {
                w.WriteLine(contents);
            } ;
        }
    }
}
