using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MySqlConnector;
using PruebaCollectionViewsConDB.Data;
using PruebaCollectionViewsConDB.Models;

namespace PruebaCollectionViewsConDB.Services
{
    public class ServicesGrupo
    {
        //public static ObservableCollection<ModelGrupo> listGrupos;
        public ServicesGrupo() { }

        public static ObservableCollection<ModelGrupo> obtenerLista()
        {

            var conexionBD = DataConexion.conectar();
            //ModelGrupo grupo = new ModelGrupo();
            
            try
            {
                ObservableCollection<ModelGrupo> listGrupos = new ObservableCollection<ModelGrupo> { };
                string query = "SELECT * FROM xxxxgrup";
                MySqlCommand comando = new MySqlCommand(query);
                MySqlDataReader reader = null;
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ModelGrupo grupo = new ModelGrupo();
                    grupo.codigo = reader.GetString(0).ToString();
                    grupo.nombre = reader.GetString(1).ToString();
                    grupo.tipo = reader.GetString(2).ToString();

                    listGrupos.Add(grupo);
                }
                reader.Close();
                conexionBD.Close();
                return listGrupos;
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            return null;
        }
        
    }
}
