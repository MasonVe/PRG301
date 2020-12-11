using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using WebAPI.models;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        static public List<Movie> movies = new List<Movie>();



        SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        IConfiguration configuration;
        string connectionString = "";

        public MovieController(IConfiguration iConfig)
        {
            this.configuration = iConfig;
            connectionString = this.configuration.GetSection("DBConnectionString").Value;
        }

        // TEST CONNECTION
        [HttpGet("TestConnection")]
        public string TestConnection()
        {
            try
            {
                string testcon = @"Data Source=no.database.here.com;Initial Catalog=ls;User ID=Wally;Password=Where";
                SqlConnection conn = new SqlConnection(testcon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string connectionString = @"Data Source=192.168.0.12;Initial Catalog=ASSIGNMENT;User ID=sa;Password=homework";
                SqlConnection conn = new SqlConnection(connectionString);
                Console.WriteLine("Connection Recieved");
            }
            return "Connected";
        }

        // READ TASK 1
        [HttpGet("ListMovies")]
        public List<Movie> MovieList()
        {
            

            
            SqlConnection conn = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM MOVIE";

            SqlCommand command = new SqlCommand(queryString, conn);
            conn.Open();

            string result = "";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result += reader[0] + "  " + reader[1] + " " + reader[2] + " " + reader[3] + "\n";
                    movies.Add(new Movie() {MOVIENO = (int)reader[0], TITLE = reader[1].ToString(), RELYEAR = (Int16)reader[2], RUNTIME = (Int16)reader[3]});
                }
            }

            return movies;
        }

        // READ TASK 2
        [HttpGet("TheTitle")]
        public string TheTitle()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM MOVIE WHERE TITLE LIKE 'The %'";
            SqlCommand command = new SqlCommand(queryString, conn);
            conn.Open();

            string result = "";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result += reader[0] + "  " + reader[1] + " " + reader[2] + " " + reader[3] + "\n";
                }
            }
            return result;
        }

        // READ TASK 3
        [HttpGet("wilson")]
        public string LukeWilson()
        {
            List<int> castmovieno = new List<int>();
            SqlConnection conn = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM CASTING WHERE ACTORNO = 36422";
            SqlCommand command = new SqlCommand(queryString, conn);
            conn.Open();

            this.MovieList();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    castmovieno.Add((int)reader[2]);
                }
            }
            
            string wilson = "";
            foreach (int MOVIENO in castmovieno)
            {
                Movie cast = movies.Find(m => m.MOVIENO == MOVIENO);

                if (cast != null)
                {
                    wilson += cast.TITLE + "\n";
                }
            }
            return wilson;
        }

        // READ TASK 4
        [HttpGet("RunTime")]
        public int TotalRunTime()
        {
            this.MovieList();
            int runtime = 0;
            foreach (Movie movie in movies)
            {
                runtime += movie.RUNTIME;
            }

            return runtime;
            //runtime = 0;

        }

        // UPDATE TASK 1

        [HttpPost("ChangeRuntime")]
        public string ChangeRuntime([FromBody] ChangeRuntime run)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryString = "UPDATE MOVIE SET RUNTIME = @NEWRUNTIME WHERE TITLE = @SAMETITLE";
            SqlCommand command = new SqlCommand(queryString, conn);

            command.Parameters.AddWithValue("@SAMETITLE", run.SAMETITLE);
            command.Parameters.AddWithValue("@NEWRUNTIME", run.NEWRUNTIME);


            var result = command.ExecuteNonQuery();
            return result.ToString();
        }


        // UPDATE TASK 2
        [HttpPost("ChangeSurname")]
        public string ChangeSurname([FromBody] ChangeSurname surname)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string OLDNAME = (surname.GIVENNAME + " " + surname.OLDSURNAME);
            string NEWFULLNAME = (surname.GIVENNAME + " " + surname.NEWSURNAME);

            string queryString = "UPDATE ACTOR SET FULLNAME = @NEWFULLNAME, SURNAME = @NEWSURNAME WHERE FULLNAME = @OLDNAME";
            SqlCommand command = new SqlCommand(queryString, conn);

            command.Parameters.AddWithValue("@NEWFULLNAME", NEWFULLNAME);
            command.Parameters.AddWithValue("@NEWSURNAME", surname.NEWSURNAME);
            command.Parameters.AddWithValue("@OLDNAME", OLDNAME);

            var result = command.ExecuteNonQuery();
            return result.ToString();
        }


        // CREATE TASK 1
        [HttpPost("AddMovie")]
        public string CreateMovie([FromBody] Movie addmovie)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

                string queryString = "INSERT INTO MOVIE (MOVIENO, TITLE, RELYEAR, RUNTIME) VALUES (@MOVIENO, @TITLE, @RELYEAR, @RUNTIME)";
                SqlCommand command = new SqlCommand(queryString, conn);
                
                command.Parameters.AddWithValue("@MOVIENO", addmovie.MOVIENO);
                command.Parameters.AddWithValue("@TITLE", addmovie.TITLE);
                command.Parameters.AddWithValue("@RELYEAR", addmovie.RELYEAR);
                command.Parameters.AddWithValue("@RUNTIME", addmovie.RUNTIME);

                var result = command.ExecuteNonQuery();
                return result.ToString();
        }

        // CREATE TASK 2
        [HttpPost("AddActor")]
        public string AddActor([FromBody] Actor addactor)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryString = "INSERT INTO ACTOR (ACTORNO, FULLNAME, GIVENNAME, SURNAME) VALUES (@ACTORNO, @FULLNAME, @GIVENNAME, @SURNAME)";
            SqlCommand command = new SqlCommand(queryString, conn);

            command.Parameters.AddWithValue("@ACTORNO", addactor.ACTORNO);
            command.Parameters.AddWithValue("@FULLNAME", addactor.FULLNAME);
            command.Parameters.AddWithValue("@GIVENNAME", addactor.GIVENNAME);
            command.Parameters.AddWithValue("@SURNAME", addactor.SURNAME);

            var result = command.ExecuteNonQuery();
            return result.ToString();
        }

        // CREATE TASK 3
        [HttpPost("AddCasting")]
        public string AddCasting([FromBody] Casting addcasting)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string queryString = "INSERT INTO CASTING (CASTID, ACTORNO, MOVIENO) VALUES (@CASTID, @ACTORNO, @MOVIENO)";
            SqlCommand command = new SqlCommand(queryString, conn);

            command.Parameters.AddWithValue("@CASTID", addcasting.CASTID);
            command.Parameters.AddWithValue("@ACTORNO", addcasting.ACTORNO);
            command.Parameters.AddWithValue("@MOVIENO", addcasting.MOVIENO);

            var result = command.ExecuteNonQuery();
            return result.ToString();
        }
        
    }
}