using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    static public class DatabaseClass
    {
        //ADO.NET


        //CRUD Operations

        static string ConnStr = "Data Source=dbserver;database=EtgAcademyDB;MultipleActiveResultSets=True;trustServerCertificate=true; user id= sa; password = Welcome123";

        static public void CreatePerson()
        {
            string Name = "Peter";
            string Gender = "Female";
            int Age = 23;
            DateTime Dob = new DateTime(1993, 1, 1);


            string insertQuery = "INSERT INTO Persontb ( Name, Gender, Age, Dob) VALUES (@Name, @Gender, @Age, @Dob)";
            using (var connection = new SqlConnection(ConnStr))
            {
                connection.Open();
                using (var command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Age", Age);
                    command.Parameters.AddWithValue("@Dob", Dob);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
                //connection.Close();
            }
        }



        static public void ReadPersons()
        {
            var name = "Peter";
            string selectQuery = "SELECT * FROM Persontb where name =@Name";
            using (var connection = new SqlConnection(ConnStr))
            {


                connection.Open();
                using (var command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nam = reader.GetString(1);
                            string gender = reader["Gender"].ToString()!;
                            int age = int.Parse(reader["Age"].ToString()!);
                            DateTime dob = reader.GetDateTime(4);
                            Console.WriteLine($"ID: {id}, Name: {nam}, Gender: {gender}, Age: {age}, Dob: {dob.ToShortDateString()}");
                        }

                    }
                }
            }
        }

        //use dataset and dataadapter
        static public void ReadPersonsDataSet()
        {
            var name = "Peter";
            string selectQuery = "SELECT * FROM Persontb where name =@Name";
            using (var connection = new SqlConnection(ConnStr))
            {
                connection.Open();
                using (var command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataSet = new System.Data.DataSet();
                        adapter.Fill(dataSet);
                        foreach (System.Data.DataRow row in dataSet.Tables[0].Rows)
                        {
                            int id = (int)row["Id"];
                            string nam = (string)row["Name"];

                        }
                    }
                }
            }
        }


        static public void UpdatePerson()
        {
            int idToUpdate = 1;
            string newName = "UpdatedName";
            string updateQuery = "UPDATE Persontb SET Name = @Name WHERE Id = @Id";
            using (var connection = new SqlConnection(ConnStr))
            {
                connection.Open();
                using (var command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", newName);
                    command.Parameters.AddWithValue("@Id", idToUpdate);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated.");
                }
            }
        }


        static public void DeletePerson()
        {
            int idToDelete = 1;
            string deleteQuery = "DELETE FROM Persontb WHERE Id = @Id";
            using (var connection = new SqlConnection(ConnStr))
            {
                connection.Open();
                using (var command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", idToDelete);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) deleted.");
                }
            }
        }





    }
}
