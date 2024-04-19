using ParcialI.Repository;
using ParcialI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParcialI.Repository
{
    public class ClienteService
    {
        public ClienteRepository ClienteRepository;

        public ClienteService(string connection)
        {
            ClienteRepository = new ClienteRepository(connection);
        }

        public void Agregar(Cliente cliente)
        {
            if (validacionCliente(cliente))
            {
                ClienteRepository.Add(cliente);
            }
            else
            {
                throw new Exception("Ha ocurrido un error! Vuelva a intentar...");
            }
        }

        private bool validacionCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return false;
            }

            // validacion de nombre, apellido y documento (cedula)
            if (string.IsNullOrEmpty(cliente.nombre) || cliente.nombre.Length < 3)
            {
                return false;
            }
            if (string.IsNullOrEmpty(cliente.apellido) || cliente.apellido.Length < 3)
            {
                return false;
            }
            if (string.IsNullOrEmpty(cliente.documento) || cliente.documento.Length < 3)
            {
                return false;
            }

            if (string.IsNullOrEmpty(cliente.celular))
            {
                return false;
            }

            Regex regex = new Regex(@"^\d{10}$");
            if (!regex.IsMatch(cliente.celular))
            {
                return false;
            }

            return true;
        }
    }
}
