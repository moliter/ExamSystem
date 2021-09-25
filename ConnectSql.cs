using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace ExamSystem
{
    public static class ConnectSql
    {
        //查询是否存在数据
        static public bool SelectDataExist(string sqlString)
        {
            bool result = false;
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UPH5BET\SQLEXPRESS;Initial Catalog=ExamSystemDB;Integrated Security=True"))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlString,sqlConnection);
                
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            result = sqlDataReader.GetInt32(0) > 0 ? true : false;
                        }
                    }

                }
                catch (Exception e)
                {
                    throw (e);
                }

            }
            return result;
        }

        //查询数据并返回查询结果
        static public DataSet SelectData(string sqlString)
        {
            DataSet dataSet = new DataSet();
            //string [,] searchResult;
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UPH5BET\SQLEXPRESS;Initial Catalog=ExamSystemDB;Integrated Security=True"))
            {
                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                    sqlDataAdapter.SelectCommand = sqlCommand;                  
                    sqlDataAdapter.Fill(dataSet);

                }
                catch(Exception e)
                {
                    throw (e);
                }
            }
            return dataSet;
        }


        //修改或删除或插入数据
        static public bool ChangeData(string sqlString)
        {
            bool flag = false;
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-UPH5BET\SQLEXPRESS;Initial Catalog=ExamSystemDB;Integrated Security=True"))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                    int sqlResult = sqlCommand.ExecuteNonQuery();
                    if (sqlResult > 0)
                    {
                        flag = true;
                    }
                }
                catch(Exception e)
                {
                    throw (e);
                }
            }
            return flag;
        }
    }
}
