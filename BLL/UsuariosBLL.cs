using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBLL
    {
        public static void Insertar(Usuarios usuario)
        {
            try
            {


                RegistroClienteDb db = new RegistroClienteDb();

                db.Usuario.Add(usuario);
                db.SaveChanges();
                db.Dispose();
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Usuarios Buscar(int ClienteId)

        {
            RegistroClienteDb db = new RegistroClienteDb();

            return db.Usuario.Find(ClienteId);

        }
    }
}
