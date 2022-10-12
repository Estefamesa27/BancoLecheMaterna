using ENTIDADES;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALIDACIONES
{
    public class ValidacionesMadre

    {
        IDatosMadreRepositorio datosMadreRepositorio;
        public ValidacionesMadre(IDatosMadreRepositorio datosMadreRepositorio)
        {
        }
            public void IngresarDatosMadre(Madre madre)
            {

            datosMadreRepositorio.IngresarDatosMadre(madre);
            }
        }
    }
