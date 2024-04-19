using System;
using ParcialI.Repository;

class Program
{
        string connectionString = "Host=localhost; port=5432; Database=optativoIII; Username=postgres; Password=12345;";

        ClienteRepository ClienteRepository = new ClienteRepository(connectionString);
        FacturaRepository FacturaRepository = new FacturaRepository(connectionString);
    }
