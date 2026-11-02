using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GameCenter_BE
{
    [Table("Tb_Videojuegos")]
    public class VideojuegoBE
    {
        [Key]
        public int IdVideojuego { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Genero { get; set; }

        [Required]
        [StringLength(50)]
        public string Plataforma { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        public decimal Puntuacion { get; set; }
        public int Dificultad { get; set; }
        public bool Terminado { get; set; }
        public bool Multijugador { get; set; }

        [StringLength(20)]
        public string TipoCompra { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }
        public IEnumerable<object> Caracteristicas { get; internal set; }
        public DateOnly FechaLanzamiento { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
