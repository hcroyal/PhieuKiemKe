using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhieuKiemKe
{
    internal class Global
    {
        public static DataEntryDataContext db_BPO = new DataEntryDataContext();
        public static DataPhieuKiemKeDataContext db = new DataPhieuKiemKeDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = ""; 
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string Strtoken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.248\PhieuKiemKe$";
        public static string Webservice = "http://10.10.10.248:8888/PhieuKiemKe/";
        public static string LoaiPhieu = "";
        public static string StrIdProject = "PhieuKiemKe";
        public static int FreeTime = 0;
        public static bool KeyEven = true;
    }
}
