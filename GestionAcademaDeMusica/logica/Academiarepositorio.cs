using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace GestionAcademaDeMusica
{
    public class AcademiaRepositorio
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        // INSTRUMENTOS

        public List<Instrumento> ObtenerInstrumentos()
        {
            var lista = new List<Instrumento>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdInstrumento, NombreInstrumento, Categoria, Marca, Estado FROM Instrumentos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Instrumento
                            {
                                IdInstrumento = (int)reader["IdInstrumento"],
                                NombreInstrumento = reader["NombreInstrumento"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Marca = reader["Marca"].ToString(),
                                Estado = reader["Estado"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al obtener instrumentos: " + ex.Message);
                }
            }
            return lista;
        }

        public void AgregarInstrumento(Instrumento i)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Instrumentos (NombreInstrumento, Categoria, Marca, Estado) VALUES (@Nombre, @Categoria, @Marca, @Estado)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", i.NombreInstrumento);
                        cmd.Parameters.AddWithValue("@Categoria", i.Categoria);
                        cmd.Parameters.AddWithValue("@Marca", i.Marca);
                        cmd.Parameters.AddWithValue("@Estado", i.Estado);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al agregar instrumento: " + ex.Message);
                }
            }
        }

        public void ActualizarInstrumento(Instrumento i)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Instrumentos SET NombreInstrumento=@Nombre, Categoria=@Categoria, Marca=@Marca, Estado=@Estado WHERE IdInstrumento=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", i.NombreInstrumento);
                        cmd.Parameters.AddWithValue("@Categoria", i.Categoria);
                        cmd.Parameters.AddWithValue("@Marca", i.Marca);
                        cmd.Parameters.AddWithValue("@Estado", i.Estado);
                        cmd.Parameters.AddWithValue("@Id", i.IdInstrumento);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al actualizar instrumento: " + ex.Message);
                }
            }
        }

        public void EliminarInstrumento(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Instrumentos WHERE IdInstrumento = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al eliminar instrumento: " + ex.Message);
                }
            }
        }

        // ALUMNOS

        public List<Alumno> ObtenerAlumnos()
        {
            var lista = new List<Alumno>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdAlumno, NombreAlumno, ApellidoAlumno, FechaNacimiento, TelefonoAlumno, EmailAlumno, ActivoAlumno, IdInstrumento FROM Alumnos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Alumno
                            {
                                IdAlumno = (int)reader["IdAlumno"],
                                NombreAlumno = reader["NombreAlumno"].ToString(),
                                ApellidoAlumno = reader["ApellidoAlumno"].ToString(),
                                FechaNacimiento = reader["FechaNacimiento"] == DBNull.Value ? DateTime.Today : (DateTime)reader["FechaNacimiento"],
                                TelefonoAlumno = reader["TelefonoAlumno"].ToString(),
                                EmailAlumno = reader["EmailAlumno"].ToString(),
                                ActivoAlumno = (bool)reader["ActivoAlumno"],
                                IdInstrumento = reader["IdInstrumento"] == DBNull.Value ? (int?)null : (int)reader["IdInstrumento"]
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al obtener alumnos: " + ex.Message);
                }
            }
            return lista;
        }

        public void AgregarAlumno(Alumno a)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Alumnos (NombreAlumno, ApellidoAlumno, FechaNacimiento, TelefonoAlumno, EmailAlumno, ActivoAlumno, IdInstrumento) VALUES (@Nombre, @Apellido, @Fecha, @Telefono, @Email, @Activo, @IdInstrumento)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", a.NombreAlumno);
                        cmd.Parameters.AddWithValue("@Apellido", a.ApellidoAlumno);
                        cmd.Parameters.AddWithValue("@Fecha", a.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Telefono", (object)a.TelefonoAlumno ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)a.EmailAlumno ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Activo", a.ActivoAlumno);
                        cmd.Parameters.AddWithValue("@IdInstrumento", (object)a.IdInstrumento ?? DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al agregar alumno: " + ex.Message);
                }
            }
        }

        public void ActualizarAlumno(Alumno a)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Alumnos SET NombreAlumno=@Nombre, ApellidoAlumno=@Apellido, FechaNacimiento=@Fecha, TelefonoAlumno=@Telefono, EmailAlumno=@Email, ActivoAlumno=@Activo, IdInstrumento=@IdInstrumento WHERE IdAlumno=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", a.NombreAlumno);
                        cmd.Parameters.AddWithValue("@Apellido", a.ApellidoAlumno);
                        cmd.Parameters.AddWithValue("@Fecha", a.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Telefono", (object)a.TelefonoAlumno ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)a.EmailAlumno ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Activo", a.ActivoAlumno);
                        cmd.Parameters.AddWithValue("@IdInstrumento", (object)a.IdInstrumento ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Id", a.IdAlumno);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al actualizar alumno: " + ex.Message);
                }
            }
        }

        public void EliminarAlumno(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Alumnos WHERE IdAlumno = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al eliminar alumno: " + ex.Message);
                }
            }
        }

        // PROFESORES

        public List<Profesor> ObtenerProfesores()
        {
            var lista = new List<Profesor>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT IdProfesor, NombreProfesor, ApellidoProfesor, TelefonoProfesor, EmailProfesor, Especialidad, TarifaHora, ActivoProfesor FROM Profesores";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Profesor
                            {
                                IdProfesor = (int)reader["IdProfesor"],
                                NombreProfesor = reader["NombreProfesor"].ToString(),
                                ApellidoProfesor = reader["ApellidoProfesor"].ToString(),
                                TelefonoProfesor = reader["TelefonoProfesor"].ToString(),
                                EmailProfesor = reader["EmailProfesor"].ToString(),
                                Especialidad = reader["Especialidad"].ToString(),
                                TarifaHora = (decimal)reader["TarifaHora"],
                                ActivoProfesor = (bool)reader["ActivoProfesor"]
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al obtener profesores: " + ex.Message);
                }
            }
            return lista;
        }

        public void AgregarProfesor(Profesor p)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO Profesores (NombreProfesor, ApellidoProfesor, TelefonoProfesor, EmailProfesor, Especialidad, TarifaHora, ActivoProfesor) VALUES (@Nombre, @Apellido, @Telefono, @Email, @Especialidad, @TarifaHora, @Activo)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", p.NombreProfesor);
                        cmd.Parameters.AddWithValue("@Apellido", p.ApellidoProfesor);
                        cmd.Parameters.AddWithValue("@Telefono", (object)p.TelefonoProfesor ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)p.EmailProfesor ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Especialidad", (object)p.Especialidad ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TarifaHora", p.TarifaHora);
                        cmd.Parameters.AddWithValue("@Activo", p.ActivoProfesor);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al agregar profesor: " + ex.Message);
                }
            }
        }

        public void ActualizarProfesor(Profesor p)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Profesores SET NombreProfesor=@Nombre, ApellidoProfesor=@Apellido, TelefonoProfesor=@Telefono, EmailProfesor=@Email, Especialidad=@Especialidad, TarifaHora=@TarifaHora, ActivoProfesor=@Activo WHERE IdProfesor=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", p.NombreProfesor);
                        cmd.Parameters.AddWithValue("@Apellido", p.ApellidoProfesor);
                        cmd.Parameters.AddWithValue("@Telefono", (object)p.TelefonoProfesor ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", (object)p.EmailProfesor ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Especialidad", (object)p.Especialidad ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TarifaHora", p.TarifaHora);
                        cmd.Parameters.AddWithValue("@Activo", p.ActivoProfesor);
                        cmd.Parameters.AddWithValue("@Id", p.IdProfesor);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al actualizar profesor: " + ex.Message);
                }
            }
        }

        public void EliminarProfesor(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM Profesores WHERE IdProfesor = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al eliminar profesor: " + ex.Message);
                }
            }
        }
    }
}