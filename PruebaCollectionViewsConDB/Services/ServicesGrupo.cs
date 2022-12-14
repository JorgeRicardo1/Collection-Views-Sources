using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PruebaCollectionViewsConDB.Models;

namespace PruebaCollectionViewsConDB.Services
{
    public class ServicesGrupo
    {
        public ObservableCollection<ModelGrupo> listGrupos;
        public ServicesGrupo() { }

        public static ObservableCollection<ModelGrupo> obtenerLista()
        {

            return new ObservableCollection<ModelGrupo>
            {
                new ModelGrupo
                {
                    codigo="100",
                    nombre="Cascos",
                    tipo="C"
                },
                new ModelGrupo
                {
                    codigo="200",
                    nombre="Tarros",
                    tipo="T"
                },
                new ModelGrupo
                {
                    codigo="300",
                    nombre="Tornillos",
                    tipo="To"
                }
            };
        }
        
    }
}
