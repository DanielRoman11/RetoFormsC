using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importar ---
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClassNegocio
    {
        ClassDatos objD = new ClassDatos();

        public DataTable N_Listar_libros()
        {
            return objD.D_listar_libros();
        }
        public DataTable N_Buscar_libros(ClassEntidad obje)
        {
            return objD.D_buscar_libros(obje);
        }
        public DataTable N_Buscar_Autor(ClassEntidad obje)
        {
            return objD.D_Buscar_Autor(obje);
        }
        public String N_mantenimiento_libro(ClassEntidad obje)
        {
            return objD.D_mantenimiento_libros(obje);
        }


    }
}
