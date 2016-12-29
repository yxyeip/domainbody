using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Database
    {
        //返回影响的行数
        static public object sql_ExecuteNonQuery( string sql)
        {
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            // string result = null;
            object objResult = null;
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand objcommand = new SqlCommand(sql, objConnection))
                {
                    objConnection.Open();
                    objResult = objcommand.ExecuteNonQuery();
                    objResult = objResult.ToString();
                    /*Console.Write(result);*/
                    objConnection.Close();
                }
            }
            return objResult;
        }

        //返回第一行第一列
       static public object sql_ExecuteScalar(string sql)
        {
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            object objResult = null;
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {
                using (SqlCommand objcommand = new SqlCommand(sql, objConnection))
                {
                    objConnection.Open();
                    objResult = objcommand.ExecuteScalar();
                    objConnection.Close();
                }
            }
            return objResult;
        }

        //返回数据集
        static public DataSet sql_Dateset(string sql)
        {
            string strConnection = "Server=Lenovo-PC;";
            strConnection += "uid=bd;";
            strConnection += "pwd=123456;database=BodyDomain";
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = strConnection;
            cnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
            sda.Fill(ds);
            return ds;
        }

    }
}
