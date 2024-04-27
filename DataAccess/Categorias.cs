// NOMBRE APELLIDOS: MARIO ANDR�S VACA MORA
// PARALELO: 3228
// SI � INTEGRACI�N DE SISTEMAS 
// FECHA: 28/04/2024
// PR�CTICA No. # 05

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Categorias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categorias()
        {
            this.Clientes = new List<Clientes>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Clientes> Clientes { get; set; }
    }
}