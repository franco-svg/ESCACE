using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UI
{
    public static class UIHelper
    {
        public static void ManejarError(Exception ex)
        {
            switch (ex.GetType().Name)
            {
                case "InvalidOperationException":
                    MessageBox.Show(ex.Message, "Error de operación indebida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "XmlException":
                    MessageBox.Show(ex.Message, "Error de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default:
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }
        public static void ValidarRazonSocial(string sRazSoc)
        {
            // Al menos un carácter válido (letra, número o especial permitido)
            Regex re = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ0-9&.,\- ]+$");

            if (!re.IsMatch(sRazSoc))
            {
                throw new InvalidOperationException("Ingrese una Razón Social válida:" + Environment.NewLine +
                                                    "• No puede estar vacía" + Environment.NewLine +
                                                    "• Puede incluir letras, números y espacios" + Environment.NewLine +
                                                    "• Se permiten caracteres: & , . -" + Environment.NewLine +
                                                    "• No se permiten símbolos especiales distintos a los mencionados");
            }
        }
        public static void ValidarPais(string sPais)
        {
            // Letras con tildes y Ñ, sin números ni símbolos.
            // El negativo evita que sea solo "_".
            Regex re = new Regex(@"^(?!_)([A-Za-zÁÉÍÓÚáéíóúÑñ ]+)$");

            if (!re.IsMatch(sPais))
            {
                throw new InvalidOperationException("Seleccione un País válido:" + Environment.NewLine +
                                                    "• No puede estar vacío ni ser '_'"
                                                   );
            }
        }
        public static void ValidarIdFiscal(string sIdFiscal, string sTipoIdFiscal)
        {
            switch (sTipoIdFiscal.ToUpper())
            {
                case "CUIT": // Argentina
                    if (!Regex.IsMatch(sIdFiscal, @"^\d{2}-\d{8}-\d{1}$"))
                        throw new InvalidOperationException("CUIT inválido." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 11 dígitos en total" + Environment.NewLine +
                                                            "• Separados en el formato ##-########-#" + Environment.NewLine +
                                                            "Ejemplo: 20-12345678-3");
                    break;

                case "RUT (CHI)": // Chile
                    if (!Regex.IsMatch(sIdFiscal, @"^\d{7,8}-[0-9Kk]$"))
                        throw new InvalidOperationException("RUT inválido (Chile)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 7 u 8 dígitos + guion + dígito verificador (0-9 o K)" + Environment.NewLine +
                                                            "Ejemplo: 12345678-9  |  87654321-K");
                    break;

                case "CNPJ": // Brasil
                    if (!Regex.IsMatch(sIdFiscal, @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$"))
                        throw new InvalidOperationException("CNPJ inválido." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 14 dígitos en total" + Environment.NewLine +
                                                            "• Separados en el formato ##.###.###/####-##" + Environment.NewLine +
                                                            "Ejemplo: 12.345.678/0001-95");
                    break;

                case "EIN": // EEUU
                    if (!Regex.IsMatch(sIdFiscal, @"^\d{2}-\d{7}$"))
                        throw new InvalidOperationException("EIN inválido." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 9 dígitos en total" + Environment.NewLine +
                                                            "• Separados en el formato ##-#######" + Environment.NewLine +
                                                            "Ejemplo: 12-3456789");
                    break;

                case "NIF": // España
                    if (!Regex.IsMatch(sIdFiscal, @"^[A-Z0-9]\d{7}[A-Z]$"))
                        throw new InvalidOperationException("NIF inválido." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• Letra/dígito inicial + 7 dígitos + letra final" + Environment.NewLine +
                                                            "Ejemplo: 12345678Z  |  X1234567L");
                    break;

                case "RUT (UY)": // Uruguay
                    if (!Regex.IsMatch(sIdFiscal, @"^\d{12}$"))
                        throw new InvalidOperationException("RUT inválido (Uruguay)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 12 dígitos numéricos sin guiones ni espacios" + Environment.NewLine +
                                                            "Ejemplo: 210123456789");
                    break;

                default:
                    throw new InvalidOperationException("No se reconoce el tipo de ID Fiscal: " + sTipoIdFiscal);
            }
        }
        public static void ValidarEmail(string sEmail)
        {
            // Valida usuario@dominio.extensión
            Regex re = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

            if (!re.IsMatch(sEmail))
            {
                throw new InvalidOperationException("Ingrese un correo electrónico válido:" + Environment.NewLine +
                                                    "• Debe contener un '@'" + Environment.NewLine +
                                                    "• Antes del '@': letras, números, '.', '-', '_'" + Environment.NewLine +
                                                    "• Después del '@': dominio válido con '.'" + Environment.NewLine +
                                                    "Ejemplos válidos: usuario@gmail.com, contacto@empresa.com.ar");
            }
        }
        public static void ValidarTelefono(string sTelefono, string sPrefijo)
        {
            switch (sPrefijo)
            {
                case "+54": // Argentina
                    if (!Regex.IsMatch(sTelefono, @"^\d{10}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (Argentina)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 10 dígitos sin el +54" + Environment.NewLine +
                                                            "Ejemplo: 1123456789");
                    break;

                case "+56": // Chile
                    if (!Regex.IsMatch(sTelefono, @"^\d{9}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (Chile)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 9 dígitos sin el +56" + Environment.NewLine +
                                                            "Ejemplo: 912345678");
                    break;

                case "+598": // Uruguay
                    if (!Regex.IsMatch(sTelefono, @"^\d{8}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (Uruguay)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 8 dígitos sin el +598" + Environment.NewLine +
                                                            "Ejemplo: 21234567");
                    break;

                case "+55": // Brasil
                    if (!Regex.IsMatch(sTelefono, @"^\d{8,9}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (Brasil)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 8 o 9 dígitos sin el +55" + Environment.NewLine +
                                                            "Ejemplo: 912345678");
                    break;

                case "+1": // EEUU
                    if (!Regex.IsMatch(sTelefono, @"^\d{10}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (EEUU)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 10 dígitos sin el +1" + Environment.NewLine +
                                                            "Ejemplo: 2125551234");
                    break;

                case "+34": // España
                    if (!Regex.IsMatch(sTelefono, @"^\d{9}$"))
                        throw new InvalidOperationException("Número de teléfono inválido (España)." + Environment.NewLine +
                                                            "Requisitos:" + Environment.NewLine +
                                                            "• 9 dígitos sin el +34" + Environment.NewLine +
                                                            "Ejemplo: 612345678");
                    break;

                default:
                    throw new InvalidOperationException("No se reconoce el sPrefijo telefónico: " + sPrefijo);
            }
        }
        public static void ValidarIndustria(string sIndustria)
        {
            // Evita que sea "_" y asegura que solo tenga letras y espacios
            Regex re = new Regex(@"^(?!_)([A-Za-zÁÉÍÓÚáéíóúÑñ ]+)$");

            if (!re.IsMatch(sIndustria))
            {
                throw new InvalidOperationException("Seleccione una Industria válida:" + Environment.NewLine +
                                                    "• No puede estar vacía ni ser '_'");
            }
        }
        public static void ValidarTitulo(string sTitulo)
        {
            // Acepta cualquier carácter, pero limita la longitud entre 1 y 100
            Regex re = new Regex(@"^.{1,100}$");

            if (!re.IsMatch(sTitulo))
            {
                throw new InvalidOperationException("Ingrese un Título válido:" + Environment.NewLine +
                                                    "• No puede estar vacío" + Environment.NewLine +
                                                    "• Puede contener cualquier tipo de carácter" + Environment.NewLine +
                                                    "• La longitud máxima permitida es de 100 caracteres");
            }
        }
        public static void ValidarDescripcion(string sDescripcion)
        {

            Regex re = new Regex(@"^[\s\S]{1,5000}$");

            if (!re.IsMatch(sDescripcion))
            {
                throw new InvalidOperationException("Ingrese una Descripción válida:" + Environment.NewLine +
                                                    "• No puede estar vacía" + Environment.NewLine +
                                                    "• Puede contener cualquier tipo de carácter" + Environment.NewLine +
                                                    "• La longitud máxima permitida es de 5000 caracteres");
            }
        }
        public static void ValidarTerminosYCondiciones(string sTerminos)
        {

            Regex re = new Regex(@"^[\s\S]{1,5000}$");

            if (!re.IsMatch(sTerminos))
            {
                throw new InvalidOperationException("Ingrese Términos y Condiciones válidos:" + Environment.NewLine +
                                                    "• No pueden estar vacíos" + Environment.NewLine +
                                                    "• Pueden contener cualquier tipo de carácter" + Environment.NewLine +
                                                    "• La longitud máxima permitida es de 5000 caracteres");
            }
        }
        public static void ValidarEstado(string sEstado)
        {
            // Permite letras, espacios y guiones bajos, pero evita que sea solo "_"
            Regex re = new Regex(@"^(?!_$)[A-Za-zÁÉÍÓÚáéíóúÑñ_ ]+$");

            if (!re.IsMatch(sEstado))
            {
                throw new InvalidOperationException("Seleccione un Estado válido:" + Environment.NewLine +
                                                    "• No puede estar vacío ni ser solo '_'");
            }
        }
        public static void ValidarMonto(string sMonto)
        {
            Regex re = new Regex(@"^(?!0+$)\d+([.,]\d{1,2})?$");

            if (!re.IsMatch(sMonto))
            {
                throw new InvalidOperationException("Ingrese un Monto válido:" + Environment.NewLine +
                                                    "• Debe ser un número decimal o entero" + Environment.NewLine +
                                                    "• Use coma para separar decimales (ej: 1500,50)" + Environment.NewLine +
                                                    "• No puede estar vacío ni ser cero");
            }
        }
        public static void ValidarDiferenciaFechasContrato(DateTime dFechaFirma, DateTime dFechaVigencia)
        {
            if (dFechaVigencia<dFechaFirma)
            {
                throw new InvalidOperationException("Ingrese fechas validas:" + Environment.NewLine +
                                                   "• La fecha de inicio de vigencia del contrato, no puede ser menor que la fecha de firma del mismo");
            }
        }
        public static void ValidarHorasEnteros(string sHoras)
        {
            // Acepta solo enteros positivos, sin ceros a la izquierda (excepto "0" no válido)
            Regex re = new Regex(@"^(?!0$)([1-9][0-9]{0,3})$");

            if (!re.IsMatch(sHoras))
                throw new InvalidOperationException("Ingrese una cantidad de horas válida:" + Environment.NewLine +
                                                    "• Debe ser un número entero positivo" + Environment.NewLine +
                                                    "• No puede ser 0 ni contener letras o símbolos" + Environment.NewLine +
                                                    "• Máximo permitido: 9999 horas");
        }
        public static void ValidarHorasDecimales(string sHoras)
        {
            // Acepta enteros o decimales positivos (incluye 0), hasta 4 dígitos enteros y 2 decimales opcionales
            Regex re = new Regex(@"^(?:\d{1,4})(?:[.,]\d{1,2})?$");

            if (!re.IsMatch(sHoras))
                throw new InvalidOperationException("Ingrese una cantidad de horas válida:" + Environment.NewLine +
                                                    "• Debe ser un número positivo (entero o decimal)" + Environment.NewLine +
                                                    "• Puede incluir hasta dos decimales (ej: 3.5 o 12,75)" + Environment.NewLine +
                                                    "• Máximo permitido: 9999.99 horas");
        }
        public static void ValidarPresupuesto(string sPresupuesto)
        {
            // Acepta números enteros o decimales positivos con coma como separador decimal
            Regex re = new Regex(@"^(?!0+(,0{1,2})?$)([1-9]\d{0,8}|\d{1,9})(,\d{1,2})?$");

            if (!re.IsMatch(sPresupuesto))
                throw new InvalidOperationException("Ingrese un presupuesto válido:" + Environment.NewLine +
                                                    "• Debe ser un número positivo" + Environment.NewLine +
                                                    "• Use coma (,) para los decimales" + Environment.NewLine +
                                                    "• Máximo 2 decimales permitidos" + Environment.NewLine +
                                                    "• No puede ser 0 ni contener letras o símbolos" + Environment.NewLine +
                                                    "• Máximo permitido: 999999999,99");
        }
        public static void ValidarDiferenciaFechasFichas(DateTime dFechaInicio, DateTime dFechaFin)
        {
            if (dFechaFin<dFechaInicio)
            {
                throw new InvalidOperationException("Ingrese fechas validas:" + Environment.NewLine +
                                                   "• La fecha de fin prevista para la ficha de proyecto, no puede ser menor que la fecha de inicio de la misma");
            }
        }
        public static void ValidarFechaHoy(DateTime dFecha)
        {
            if (dFecha<DateTime.Today)
            {
                throw new InvalidOperationException("Ingrese una fecha valida:" + Environment.NewLine +
                                                   "• La fecha ingresada no puede ubicarse en el pasado");
            }
        }
        public static void ValidarCategoria(string sEstado)
        {
            // Permite letras, espacios y guiones bajos, pero evita que sea solo "_"
            Regex re = new Regex(@"^(?!_$)[A-Za-zÁÉÍÓÚáéíóúÑñ_ ]+$");

            if (!re.IsMatch(sEstado))
            {
                throw new InvalidOperationException("Seleccione una categoría válida:" + Environment.NewLine +
                                                    "• No puede estar vacía ni ser solo '_'");
            }
        }
        public static void ValidarNombreRol(string sNombre)
        {
            // Acepta cualquier carácter, pero limita la longitud entre 1 y 100
            Regex re = new Regex(@"^.{1,100}$");

            if (!re.IsMatch(sNombre))
            {
                throw new InvalidOperationException("Ingrese un nombre válido:" + Environment.NewLine +
                                                    "• No puede estar vacío" + Environment.NewLine +
                                                    "• Puede contener cualquier tipo de carácter" + Environment.NewLine +
                                                    "• La longitud máxima permitida es de 100 caracteres");
            }
        }
        public static void ValidarNombreColaborador(string sNombre)
        {
            // Solo letras, incluyendo acentos y ñ, permite espacios para nombres compuestos
            Regex re = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ ]+$");

            if (!re.IsMatch(sNombre))
            {
                throw new InvalidOperationException("Ingrese un nombre válido:" + Environment.NewLine +
                                                    "• No puede estar vacío" + Environment.NewLine +
                                                    "• Solo puede incluir letras y espacios" + Environment.NewLine +
                                                    "• No se permiten números ni símbolos especiales");
            }

        }
        public static void ValidarApellido(string sApellido)
        {
            // Solo letras, incluyendo acentos y ñ, permite espacios y guiones (ej: De la Cruz, Pérez-García)
            Regex re = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ \-]+$");

            if (!re.IsMatch(sApellido))
            {
                throw new InvalidOperationException("Ingrese un apellido válido:" + Environment.NewLine +
                                                    "• No puede estar vacío" + Environment.NewLine +
                                                    "• Solo puede incluir letras, espacios y guiones" + Environment.NewLine +
                                                    "• No se permiten números ni símbolos especiales");
            }
        }
        public static void ValidarDni(string sDni)
        {
            // Solo números, entre 7 y 8 dígitos (formato típico de DNI argentino)
            Regex re = new Regex(@"^\d{7,8}$");

            if (!re.IsMatch(sDni))
            {
                throw new InvalidOperationException("Ingrese un DNI válido:" + Environment.NewLine +
                                                    "• Solo debe contener números" + Environment.NewLine +
                                                    "• Debe tener entre 7 y 8 dígitos" + Environment.NewLine +
                                                    "• No se permiten letras, espacios ni símbolos");
            }
        }
        public static void ValidarSeniority(string sSeniority)
        {
            // Permite letras, espacios y guiones bajos, pero evita que sea solo "_"
            Regex re = new Regex(@"^(?!_$)[A-Za-zÁÉÍÓÚáéíóúÑñ_ ]+$");

            if (!re.IsMatch(sSeniority))
            {
                throw new InvalidOperationException("Seleccione una seniority válida:" + Environment.NewLine +
                                                    "• No puede estar vacía ni ser solo '_'");
            }
        }
        public static void ValidarRol(string sRol)
        {
            // Permite letras, espacios y guiones bajos, pero evita que sea solo "_"
            Regex re = new Regex(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ0-9 _\-/&+#.]+$");
            if (!re.IsMatch(sRol))
            {
                throw new InvalidOperationException("Seleccione un rol válido:" + Environment.NewLine +
                                                    "• No puede estar vacío");
            }
        }
        public static void ValidarCriterioAlcance(string sCriterio)
        {

            Regex re = new Regex(@"^[\s\S]{1,5000}$");

            if (!re.IsMatch(sCriterio))
            {
                throw new InvalidOperationException("Ingrese una criterio de alcance válido:" + Environment.NewLine +
                                                    "• No puede estar vacío" + Environment.NewLine +
                                                    "• Puede contener cualquier tipo de carácter" + Environment.NewLine +
                                                    "• La longitud máxima permitida es de 5000 caracteres");
            }
        }
        public static void ValidarUsername(string sUsername)
        {
            // Letras, números, punto, guion y guion bajo, entre 3 y 20 caracteres
            Regex re = new Regex(@"^(?!\s*$).+");

            if (!re.IsMatch(sUsername))
            {
                throw new InvalidOperationException("Ingrese un nombre de usuario válido:" + Environment.NewLine +
                                                    "• No debe estar vacio");
            }
        }
        public static void ValidarPassword(string sPassword)
        {
            // Al menos 1 mayúscula, 1 minúscula, 1 número, 1 símbolo, y entre 8 y 20 caracteres
            Regex re = new Regex(@"^(?!\s*$).+");

            if (!re.IsMatch(sPassword))
            {
                throw new InvalidOperationException("Ingrese una contraseña válida:" + Environment.NewLine +
                                                    "• No debe estar vacio");
            }
        }
        public static void ValidarDiferenciaFechasFiltros(DateTime dFechaInicio, DateTime dFechaFin)
        {
            if (dFechaFin<dFechaInicio)
            {
                throw new InvalidOperationException("Ingrese fechas validas:" + Environment.NewLine +
                                                   "• La fecha inicial del filtro debe ser menor que la fecha final");
            }
        }
    }
}
