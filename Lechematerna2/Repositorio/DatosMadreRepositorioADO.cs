using ENTIDADES;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;




namespace Repositorio
{
    public interface IDatosMadreRepositorio
    {
        void IngresarDatos(Madre DatosMadre);
    }

    public class DatosMadreRepositorioADO : IDatosMadreRepositorio
    {
        public void IngresarDatos(Madre DatosMadre)
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["BancoLecheMaterna"].ConnectionString;
            using (var conexion = new SqlConnection(cadenaConexion))

            {
                conexion.Open();

                var comando = new SqlCommand();
                comando.CommandText = "IngresarDatosMadre";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;

                comando.Parameters.Add("@TipoDocumento nvarchar(50)", System.Data.SqlDbType.NVarChar, 50).Value = DatosMadre.TipoDocumento;
                comando.Parameters.Add("@NúmeroDocumento int", System.Data.SqlDbType.Int).Value = DatosMadre.NumeroD;
                comando.Parameters.Add("@Dirección nvarchar(50)", System.Data.SqlDbType.NVarChar, 50).Value = DatosMadre.Direccion;
                comando.Parameters.Add("@Ciudad nvarchar(50)", System.Data.SqlDbType.NVarChar, 50).Value = DatosMadre.Ciudad;
                comando.Parameters.Add("@Teléfono int", System.Data.SqlDbType.Int).Value = DatosMadre.Telefono;
                comando.Parameters.Add("@FechaNacimietno datetime2(7)", System.Data.SqlDbType.DateTime2, 50).Value = DatosMadre.FechaNacimiento;
                comando.Parameters.Add("@Peso decimal(18,2)", System.Data.SqlDbType.Decimal, 10).Value = DatosMadre.Peso;
                comando.Parameters.Add("@Talla decimal(18,2)", System.Data.SqlDbType.Decimal, 10).Value = DatosMadre.Talla;
                comando.Parameters.Add(" @IMC decimal(18,2)", System.Data.SqlDbType.Decimal, 10).Value = DatosMadre.IMC;
                comando.Parameters.Add("@UsaMedicamentos bit", System.Data.SqlDbType.Bit).Value =
                comando.Parameters.Add("@TieneHabitosToxicos bit", System.Data.SqlDbType.Bit).Value =
                comando.Parameters.Add("@FechaÚltimaRegla datetime2(7)", System.Data.SqlDbType.DateTime2, 50).Value = DatosMadre.FRegla;
                comando.Parameters.Add("@FechaParto datetime2(7)", System.Data.SqlDbType.DateTime2, 50).Value = DatosMadre.FParto;
                comando.Parameters.Add("@EdadAmenorrea int", System.Data.SqlDbType.Int).Value = DatosMadre.Amenorrea;
                comando.Parameters.Add("@PatologíaEmbarazo nvarchar(50)", System.Data.SqlDbType.NVarChar, 50).Value = DatosMadre.PatologíaEmbarazo;
            }

            }
        }


    }
