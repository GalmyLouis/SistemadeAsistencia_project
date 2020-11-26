using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceSystem.Class
{
    public class EmpleadoFill
    {
        
       private  DataAccess _dataAccess;
        
        public EmpleadoFill()
        {
            _dataAccess = new DataAccess();
        }
        public ClassEmpleados SaveEmployes(ClassEmpleados classEmpleados)
        {
            if (classEmpleados.id == 0)
            {
                _dataAccess.InsertarEmpleados(classEmpleados);
            }
            // else
            //  {
            //_dataAccess.modificarEmpleados
            //}
            return classEmpleados;
        }
        public List<ClassEmpleados> GetEmpleados()
        {
                 return _dataAccess.mostrarEmpleado();

            
            
        }

        public ClassAsistencia SaveAsistent(ClassAsistencia classAsistencia)
        {
             _dataAccess.GuardarAsistencia(classAsistencia);

            return classAsistencia;
        }
    }
}
