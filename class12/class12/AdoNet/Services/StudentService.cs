using Microsoft.Data.SqlClient;
using AdoNet.Models;
using Microsoft.Data.SqlClient.Server;

namespace AdoNet.Services
{
    public class StudentService
    {
        private readonly string _connectionString;
        public StudentService(string connectionString)
        {
            _connectionString = connectionString;
        }
        // retrives all students records from databse
        //<returns>
        //A list of <see cref="Student"/> object representing all students in database.
        //<returns/>
        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            //1.Establish the connection to the databse
            //BAD WAY
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //....
            //connection.Close();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                //2. Write the SQL Query
                //string query = @"Select * FROM dbo.Student";
                string query = @"
                Select s.ID, s.FirstName, s.LastName, s.DateofBirth, s.EnrolledDate, s.Gender, s.NationalIdNumber, s.StudentCardNumber
                FROM [dbo].[Student] s";
                //3. Create sql command
                using SqlCommand command = new SqlCommand(query, sqlConnection);
                //4. Execute the sql command
                using SqlDataReader reader = command.ExecuteReader();
                //5. Read the data from executed query
                while (reader.Read())
                {
                    //6. Map manually the retrieved columns to Student object
                    var student = new Student
                    {
                        //IMPORTANT: the order of the columns is the one written in the SELECT query
                        Id = reader.GetInt32(0),
                        FirstName = reader.IsDBNull(1) ? "N/A" : reader.GetString(1),
                        LastName = reader.GetString(2),
                        DateOfBirth = reader.GetDateTime(3),
                        EnrolledDate = reader.GetDateTime(4),
                        Gender = reader.GetString(5)[0],
                        NationalIdNumber = reader.GetInt64(6),
                        StudentCardNumber = reader.GetString(7)
                    };
                    students.Add(student);
                }
            }
            return students;
        }
        //insert a new student record into a database
        public void InsertStudent(Student student)
        {
            //1.Establish the connection to the databse
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                //2. Write the SQL Query
                string query = $@"
INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
VALUES (@FirstName, @LastName, @DOB, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)";

                //3. Create sql command
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                //4. Map the insert values
                sqlCommand.Parameters.AddWithValue("@LastName", student.LastName);
                sqlCommand.Parameters.AddWithValue("@FirstName", (object?)student.FirstName ?? DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@EnrolledDate", student.EnrolledDate);
                sqlCommand.Parameters.AddWithValue("@DOB", student.DateOfBirth);
                sqlCommand.Parameters.AddWithValue("@Gender", student.Gender);
                sqlCommand.Parameters.AddWithValue("@NationalIdNumber", student.NationalIdNumber);
                sqlCommand.Parameters.AddWithValue("@StudentCardNumber", student.StudentCardNumber);
                //5.execute the query
                int rowAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Rows Affected " + rowAffected);

            }
        }
        //insert a new student record into DB
        //VULNERABLE TO SQL INJECTION !

        public void InsertStudentMalicious(Student student)
        {
            //1.Establish the connection to the databse
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                //2. Write the SQL Query
                string query = $@"
                    INSERT INTO dbo.Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
                    VALUES('{student.FirstName}', '{student.LastName}', '{student.DateOfBirth:yyyy-MM-dd}', '{student.EnrolledDate:yyyy-MM-dd}', '{student.Gender}', {student.NationalIdNumber}, '{student.StudentCardNumber}')
                ";

                //3. Create sql command
                using SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                //4. Execute the sql command
                sqlCommand.ExecuteNonQuery();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("n\n\t==Buy Buy Table... =====\n\n");
                Console.ResetColor();

            }
        }
        //retrieves a student record by their unique ID
        //<param name="id">the ID of the student to retrieve</param>
        //<returns>
        //A <see cref="Student"/> object if a student with the specific ID exists; otherwise <i>null</i>
        //</returns>
        public Student? GetStudentById(int id)
        {
            Student? student = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                Select s.ID, s.FirstName, s.LastName, s.DateofBirth, s.EnrolledDate, s.Gender, s.NationalIdNumber, s.StudentCardNumber
                FROM dbo.Student s
                WHERE s.ID = @StudentId";
                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", id);
                using SqlDataReader reader = command.ExecuteReader();
                //read the data from executed query
                if (reader.Read())
                {
                    //Map the student info
                    student = new Student
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                        EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                        Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                        NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                        StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                    };
                }
            }
            return student;
        }

    }
}
