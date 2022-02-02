namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        public int EmpleadoId { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(150)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(15)]
        public string Celular { get; set; }

        public int DepartamentoId { get; set; }

        public int ProyectoId { get; set; }

        public virtual Departamento Departamento { get; set; }

        public virtual Proyecto Proyecto { get; set; }
    }
}
