﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace KetNoiDB
{
    public class KetNoi
    {
        SqlConnection cn = new SqlConnection();
        
        public static String connect()
        {
            return (@"Data Source=KEVIL-PC;Initial Catalog=QL_ThuVien;Integrated Security=true;");
        }
      
    }
}
