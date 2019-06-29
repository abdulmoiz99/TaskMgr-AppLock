using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project.Classes
{
    public static class SQL
    {
       
        public static String ScalarQuery(String Query)
        {
            String Result = string.Empty;
            try
            {

            if (AppObject.Con.State == ConnectionState.Open)
            {
                AppObject.Con.Close();
            }
            AppObject.Con.Open();
            SqlCommand cmd = new SqlCommand(Query, AppObject.Con);
            Result= cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Scalar Query" + ex.Message);
            }
            finally
            {
                AppObject.Con.Close();
            }
            return Result;
        }
        public static void NonScalarQuery(String Query)
        {
            try
            {
                if (AppObject.Con.State == ConnectionState.Open)
                {
                    AppObject.Con.Close();
                }
                AppObject.Con.Open();
                SqlCommand cmd = new SqlCommand(Query, AppObject.Con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " +ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL"+ ex.Message);
            } 
            finally
            {
                AppObject.Con.Close();
            }
        }
    }
}
