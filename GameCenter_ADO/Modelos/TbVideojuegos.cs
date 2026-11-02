using System;
using System.Collections.Generic;

namespace GameCenter_ADO.Modelos;

public partial class TbVideojuegos
{
    public int IdVideojuego { get; set; }

    public string Nombre { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Plataforma { get; set; } = null!;

    public DateOnly FechaLanzamiento { get; set; }

    public decimal Puntuacion { get; set; }

    public int Dificultad { get; set; }

    public bool Terminado { get; set; }

    public bool Multijugador { get; set; }

    public string? TipoCompra { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Caracteristicas { get; set; }
}
