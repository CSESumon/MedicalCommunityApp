﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalCommunityAutomation.DAO;

namespace MedicalCommunityAutomation.DAL
{
    public class CenterDbGateway : DbGateway
    {
        public void SaveCenter(Center aCenter)
        {
            string query = "INSERT INTO tbl_center VALUES('" + aCenter.Name + "','" + aCenter.DistrictId + "','" + aCenter.ThanaId + "','" + aCenter.CreateCode() + "','" + aCenter.CreatePassword() + "')";
            ASqlConnection.Open();
            ASqlCommand = new SqlCommand(query, ASqlConnection);
            ASqlCommand.ExecuteNonQuery();
            ASqlConnection.Close();

        }

        public int Find(string code, string password)
        {
             
            string query = "SELECT *FROM tbl_center WHERE center_code='" + code + "'AND center_password='" + password +
                           "';";
            ASqlConnection.Open();
            ASqlCommand=new SqlCommand(query,ASqlConnection);
            ASqlDataReader = ASqlCommand.ExecuteReader();
            if (ASqlDataReader.HasRows)
            {
                int centerId = 0;
                while (ASqlDataReader.Read())
                {
                    centerId = Convert.ToInt32(ASqlDataReader["id"]);
                }
                ASqlConnection.Close();
                return centerId;
            }
            ASqlConnection.Close();
            return 0;
        }
        
    }
}
