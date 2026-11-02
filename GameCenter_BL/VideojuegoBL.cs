using System.Collections.Generic;
using GameCenter_ADO;
using GameCenter_BE;
using System;

namespace GameCenter_BL
{
    public class VideojuegoBL
    {
        private VideojuegoADO objDatos = new VideojuegoADO();

        public List<VideojuegoBE> ListarVideojuegos(string filtro)
        {
            return objDatos.ListarVideojuegos(filtro);
        }

        public bool InsertarVideojuego(VideojuegoBE videojuego)
        {
            return objDatos.InsertarVideojuego(videojuego);
        }

        public bool ActualizarVideojuego(VideojuegoBE videojuego)
        {
            return objDatos.ActualizarVideojuego(videojuego);
        }

        public bool EliminarVideojuego(int idVideojuego)
        {
            return objDatos.EliminarVideojuego(idVideojuego);
        }

        public VideojuegoBE ConsultarVideojuego(int idVideojuego)
        {
            return objDatos.ConsultarVideojuego(idVideojuego);
        }

        public void RegistrarVideojuego(VideojuegoBE obj)
        {
            // Regla 1: Campo obligatorio
            if (string.IsNullOrEmpty(obj.Nombre))
            {
                throw new Exception("El nombre del videojuego es obligatorio.");
            }

            // Regla 2: Rango numérico (Regla no trivial)
            if (obj.Puntuacion < 0 || obj.Puntuacion > 10)
            {
                throw new Exception("La puntuación del videojuego debe estar en un rango de 0 a 10.");
            }

            // Regla 3: Validación de fecha lógica
            if (obj.Fecha > DateTime.Today)
            {
                throw new Exception("La fecha de lanzamiento no puede ser una fecha futura.");
            }

            // Si pasa las reglas, se envía a la capa ADO
            objDatos.InsertarVideojuego(obj);
        }

        public List<VideojuegoBE> ListarVideojuegosPorPeriodo(DateTime desde, DateTime hasta, string plataforma)
        {
            // Validamos las reglas del negocio antes de consultar la base de datos
            ValidarPeriodo(desde, hasta);

            // Traducimos opciones de la interfaz visual a un formato limpio para la capa ADO
            string filtroPlataforma = (plataforma == null || plataforma == "(Todas)") ? "" : plataforma;

            return objDatos.ListarVideojuegosPorPeriodo(desde.Date, hasta.Date, filtroPlataforma);
        }

        private void ValidarPeriodo(DateTime desde, DateTime hasta)
        {
            if (desde.Date > hasta.Date)
            {
                throw new Exception("La fecha inicial no puede ser posterior a la fecha final.");
            }

            /*
            if ((hasta.Date - desde.Date).TotalDays > 366)
            {
                throw new Exception("Consulte como máximo un año a la vez.");
            }*/
        }

        public List<ResumenPlataformaBE> ResumenPorPlataforma(DateTime desde, DateTime hasta)
        {
            if (desde > hasta)
            {
                throw new Exception("La fecha inicial no puede ser posterior a la fecha final.");
            }

            return objDatos.ResumenPorPlataforma(desde, hasta);
        }


    }
}