namespace Datos
{
    using System;
    using System.Collections.Generic;/*
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;*/
    //    [Table("Departamento")]
    public partial class Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departamento()
        {
            Empleado = new HashSet<Empleado>();
        }

        public int DepartamentoId { get; set; }

        //[Required]
        //[StringLength(50)]
        public string NombreDepartamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }
    }
}
