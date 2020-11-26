using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistanceSystem.Class
{
    public class DataAccess
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=Asistencia;Data Source=DESKTOP-D9VQ79U");
        
        public void InsertarEmpleados(ClassEmpleados classEmpleados)
        {
            try
            {
                conn.Open();
                string Query = @"INSERT into tblEmpleados (CodigoEmpleado, Nombre, Apellido,
                            Cedula, Direccion, Email, Cargo, Telefono
                            ) VALUES(@CodigoEmpleado, @Nombre, @Apellido, @Cedula,
                             @Direccion, @Email, @Cargo, @Telefono
                            )";
                SqlParameter codigo = new SqlParameter("@CodigoEmpleado", classEmpleados.CodigoEmpleado);
                SqlParameter nombre = new SqlParameter("@Nombre", classEmpleados.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", classEmpleados.Apellido);
                SqlParameter cedula = new SqlParameter("@Cedula", classEmpleados.Cedula);
                SqlParameter direccion = new SqlParameter("@Direccion", classEmpleados.Direccion);
                SqlParameter email = new SqlParameter("@Email", classEmpleados.Email);
                SqlParameter cargo = new SqlParameter("@Cargo", classEmpleados.Cargo);
                SqlParameter telefono = new SqlParameter("@Telefono", classEmpleados.Telefono);

                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add(codigo);
                cmd.Parameters.Add(nombre);
                cmd.Parameters.Add(apellido);
                cmd.Parameters.Add(cedula);
                cmd.Parameters.Add(direccion);
                cmd.Parameters.Add(email);
                cmd.Parameters.Add(cargo);
                cmd.Parameters.Add(telefono);
                cmd.ExecuteNonQuery();

                MessageBox.Show("----------Empleado Guardado Correctamente--------- ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                conn.Close();
            }

          
            
        }

        public void GuardarAsistencia(ClassAsistencia classAsistencia)
        {
            try{
                conn.Open();
                string Query = @"insert into tblAsistencia 
                (CodigoEmpleado, HoraDeEntrada)values( @CodigoEmpleado, @HoraDeEntrada)";
                SqlParameter codigo = new SqlParameter("@CodigoEmpleado", classAsistencia.CodigoEmpleado);
                SqlParameter hora = new SqlParameter("@Nombre", classAsistencia.HoraDeEntrada);
                

                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add(codigo);
                cmd.Parameters.Add(hora);
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("----------Asistencia--------- ");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            finally
            {
                conn.Close();
            }

        }

        public List<ClassEmpleados> mostrarEmpleado()
        {
            List<ClassEmpleados> classEmpleados = new List<ClassEmpleados>();
            try
            {
                conn.Open();
                string query = @"SELECT * from tblEmpleados";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    classEmpleados.Add(new ClassEmpleados
                    {

                        id = int.Parse(reader["id"].ToString()),
                        CodigoEmpleado = reader["CodigoEmpleado"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        Email = reader["Email"].ToString(),
                        Cargo = reader["Cargo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                    });
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
               
            }
            finally
            {
                conn.Close();
            }
            return classEmpleados;
        }

    }
}
