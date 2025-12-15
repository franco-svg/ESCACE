using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string IdFiscal { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public BEEPais Pais { get; set; }

        public BEEIndustria Industria { get; set; }

        public BECliente(string razonSocial, string idFiscal, string email, string telefono, BEEPais pais, BEEIndustria industria)
        {
            RazonSocial=razonSocial;
            IdFiscal=idFiscal;
            Email=email;
            Telefono=telefono;
            Pais=pais;
            Industria=industria;
        }
        public BECliente() { }

        public override string ToString()
        {
            return $"{RazonSocial} | {Pais} | {Industria}";
        }

    }
}
