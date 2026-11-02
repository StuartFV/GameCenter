using System.Collections.Generic;
using System.Linq;
using GameCenter_ADO.Modelos;
using GameCenter_BE;

namespace GameCenter_ADO
{
    public class VideojuegoADO
    {
        public List<VideojuegoBE> ListarVideojuegos(string filtro)
        {
            using (GameCenterContext contexto = new GameCenterContext())
            {
                // Ajusta "Titulo" o el nombre de tus campos según tu tabla generada por Scaffold
                return contexto.TbVideojuegos
                    .Where(v => filtro == "" || v.Nombre.Contains(filtro))
                    .OrderByDescending(v => v.IdVideojuego)
                    .AsEnumerable()
                    .Select(v => ConvertirABE(v))
                    .ToList();
            }
        }

        public bool InsertarVideojuego(VideojuegoBE videojuego)
        {
            using (GameCenterContext contexto = new GameCenterContext())
            {
                TbVideojuegos nueva = new TbVideojuegos();
                CopiarDatos(videojuego, nueva);
                contexto.TbVideojuegos.Add(nueva);
                bool grabado = contexto.SaveChanges() == 1;
                videojuego.IdVideojuego = nueva.IdVideojuego; // Recuperar el ID autogenerado
                return grabado;
            }
        }

        public bool ActualizarVideojuego(VideojuegoBE videojuego)
        {
            using (GameCenterContext contexto = new GameCenterContext())
            {
                TbVideojuegos existente = contexto.TbVideojuegos.Find(videojuego.IdVideojuego);
                if (existente == null) return false;

                CopiarDatos(videojuego, existente);
                contexto.SaveChanges();
                return true;
            }
        }

        public bool EliminarVideojuego(int idVideojuego)
        {
            using (GameCenterContext contexto = new GameCenterContext())
            {
                TbVideojuegos existente = contexto.TbVideojuegos.Find(idVideojuego);
                if (existente == null) return false;

                contexto.TbVideojuegos.Remove(existente);
                return contexto.SaveChanges() == 1;
            }
        }

        public VideojuegoBE ConsultarVideojuego(int idVideojuego)
        {
            using (GameCenterContext contexto = new GameCenterContext())
            {
                TbVideojuegos existente = contexto.TbVideojuegos.Find(idVideojuego);
                return existente == null ? null : ConvertirABE(existente);
            }
        }

        public List<VideojuegoBE> ListarVideojuegosPorPeriodo(DateTime desde, DateTime hasta, string plataforma)
        {
            DateOnly inicio = DateOnly.FromDateTime(desde);
            DateOnly fin = DateOnly.FromDateTime(hasta);

            using (GameCenterContext contexto = new GameCenterContext())
            {
                return contexto.TbVideojuegos
                    .Where(v => v.FechaLanzamiento >= inicio && v.FechaLanzamiento <= fin)
                    // Se agregó "Todos" para que coincida con el ComboBox
                    .Where(v => plataforma == "" || plataforma == "Todos" || plataforma == "(Todas)" || v.Plataforma == plataforma)
                    .OrderBy(v => v.FechaLanzamiento)
                    .AsEnumerable()
                    .Select(v => ConvertirABE(v))
                    .ToList();
            }
        }

        // --- Conversión completa para que la grilla muestre todos los datos ---
        private static VideojuegoBE ConvertirABE(TbVideojuegos v)
        {
            return new VideojuegoBE
            {
                IdVideojuego = v.IdVideojuego,
                Nombre = v.Nombre,
                Genero = v.Genero,
                Plataforma = v.Plataforma,
                Puntuacion = v.Puntuacion,
                Dificultad = v.Dificultad,
                Terminado = v.Terminado,
                Multijugador = v.Multijugador,
                TipoCompra = v.TipoCompra,
                Descripcion = v.Descripcion,
                FechaLanzamiento = v.FechaLanzamiento,
                Fecha = v.FechaLanzamiento.ToDateTime(TimeOnly.MinValue) // Mapea ambas propiedades de fecha para evitar conflictos
            };
        }

        private void CopiarDatos(VideojuegoBE origen, TbVideojuegos destino)
        {
            destino.Nombre = origen.Nombre;
            destino.Genero = origen.Genero;
            destino.Plataforma = origen.Plataforma;
            destino.Puntuacion = origen.Puntuacion;
            destino.Dificultad = origen.Dificultad;
            destino.Terminado = origen.Terminado;
            destino.Multijugador = origen.Multijugador;
            destino.TipoCompra = origen.TipoCompra;
            destino.Descripcion = origen.Descripcion;
            destino.FechaLanzamiento = origen.FechaLanzamiento;
        }

        public List<ResumenPlataformaBE> ResumenPorPlataforma(DateTime desde, DateTime hasta)
        {
            DateOnly inicio = DateOnly.FromDateTime(desde);
            DateOnly fin = DateOnly.FromDateTime(hasta);

            using (GameCenterContext contexto = new GameCenterContext())
            {
                return contexto.TbVideojuegos
                    .Where(v => v.FechaLanzamiento >= inicio && v.FechaLanzamiento <= fin)
                    .GroupBy(v => v.Plataforma)
                    .Select(g => new ResumenPlataformaBE
                    {
                        Plataforma = g.Key,
                        TotalVideojuegos = g.Count(),
                        PromedioPuntuacion = (double)g.Average(v => v.Puntuacion)
                    })
                    .OrderByDescending(r => r.TotalVideojuegos)
                .ToList();
            }
        }

    }
}