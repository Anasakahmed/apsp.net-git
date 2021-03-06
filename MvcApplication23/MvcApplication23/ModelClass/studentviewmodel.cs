﻿using MvcApplication23.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MvcApplication23.ModelClass
{
    public class studentviewmodel
    {
        
        string cs = ConfigurationManager.ConnectionStrings["test"].ConnectionString;



        public List<students> getallemployees()
        {
            List<students> li = new List<students>();

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("showstudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                students emp = new students();
                emp.stu_id = int.Parse(rdr["STU_ID"].ToString());
                emp.stu_name = rdr["STU_NAME"].ToString();
                emp.stu_domicile = rdr["STU_DOMICILE"].ToString();
                emp.stu_fname=rdr["STU_FNAME"].ToString();
                emp.stu_cnic = rdr["STU_CNIC"].ToString();
                emp.stu_dob = rdr["STU_DOB"].ToString();
                emp.stu_address = rdr["STU_ADDRESS"].ToString();
                emp.stu_city = rdr["STU_CITY"].ToString();

                li.Add(emp);
            }

            return li;


        }//method end....................




























        public string insert_loginmethod(students stu)
        {
            string s = "";
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT_STUDENT_REG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@STU_CNIC", SqlDbType.NVarChar, 20).Value = stu.stu_cnic;
                cmd.Parameters.Add("@STU_NAME", SqlDbType.NVarChar, 50).Value = stu.stu_name;
                cmd.Parameters.Add("@STU_FNAME", SqlDbType.NVarChar, 50).Value = stu.stu_fname;
                cmd.Parameters.Add("@STU_ADDRESS", SqlDbType.NVarChar, 50).Value = stu.stu_address;
                cmd.Parameters.Add("@STU_DOB", SqlDbType.NVarChar, 50).Value = stu.stu_dob;
                cmd.Parameters.Add("@STU_NATIONALITY ", SqlDbType.NVarChar, 50).Value = stu.nationality;
                cmd.Parameters.Add("@STU_DOMICILE", SqlDbType.NVarChar, 50).Value = stu.stu_domicile;
                cmd.Parameters.Add("@STU_CITY", SqlDbType.NVarChar, 50).Value = stu.stu_city;
                SqlParameter paramNewId = new SqlParameter()
                {
                    ParameterName = "@NEWID",
                    Value = -1,
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramNewId);
                
                conn.Open();
                cmd.ExecuteNonQuery();


                s = cmd.Parameters["@NEWID"].Value.ToString();

            }
            catch (Exception)
            {
                s = "-1";

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........




        //ssc  method.........................................................

        public bool insert_ssc(students stu ,string id)
        {
            bool s = false;
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ssc_studnet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //ssc record.......................................................................
                cmd.Parameters.Add("@ssc_institute", SqlDbType.NVarChar, 50).Value = stu.ssc_institute;
                cmd.Parameters.Add("@ssc_board", SqlDbType.NVarChar, 50).Value = stu.ssc_board;
                cmd.Parameters.Add("@ssc_totalmarks", SqlDbType.Int).Value = stu.ssc_totalmarks;
                cmd.Parameters.Add("@ssc_enrolment", SqlDbType.NVarChar, 50).Value = stu.ssc_enrolment;
                cmd.Parameters.Add("@ssc_fk_studentreg", SqlDbType.Int).Value = id;

                conn.Open();
                cmd.ExecuteNonQuery();

                s = true;
                
            }
            catch (Exception)
            {
                s = false;

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........





        //hsc method........................................

        public bool insert_hsc(students stu, string id)
        {
           bool s ;
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_hsc_studnet", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                //hsc.......................................................................

                cmd.Parameters.Add("@hsc_institute", SqlDbType.NVarChar, 50).Value = stu.hsc_institute;
                cmd.Parameters.Add("@hsc_board", SqlDbType.NVarChar, 50).Value = stu.hsc_board;
                cmd.Parameters.Add("@hsc_totalmarks", SqlDbType.Int).Value = stu.hsc_totalmarks;
                cmd.Parameters.Add("@hsc_enrolment", SqlDbType.NVarChar, 50).Value = stu.hsc_enrolment;
                cmd.Parameters.Add("@hsc_fk_studentreg", SqlDbType.Int).Value = id;


                conn.Open();
                cmd.ExecuteNonQuery();


                s =true;

            }
            catch (Exception)
            {
                s = false;

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........








        //file path method.................
        public bool insert_filepath(string f1,string f2,string id)
        {
            bool s;
            SqlConnection conn = new SqlConnection(cs);
            try
            {
                SqlCommand cmd = new SqlCommand("insert_filepath", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //file.......................................................................

                cmd.Parameters.Add("@filenamessc", SqlDbType.NVarChar, 50).Value = f1;
                cmd.Parameters.Add("@filenamehsc", SqlDbType.NVarChar, 50).Value = f2;
                cmd.Parameters.Add("@fk_stu_id", SqlDbType.Int).Value = id;

                

                conn.Open();
                cmd.ExecuteNonQuery();


                s = true;

            }
            catch (Exception)
            {
                s = false;

            }

            finally
            {
                conn.Close();
            }

            return s;

        } //method end...........



   









    }
}