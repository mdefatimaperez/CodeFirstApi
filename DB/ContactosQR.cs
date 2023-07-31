using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ContactosQR
    {
        //id autogenerado
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //foto contacto
        public byte[] Foto { get; set; }

        //nombre
        [Display(Name = "Nombre del contacto")]
        [StringLength(200, ErrorMessage = "Longitud entre 2 y 200 caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        //apellido
        [Display(Name = "Apellido del contacto")]
        [StringLength(300, ErrorMessage = "Longitud entre 2 y 300 caracteres.", MinimumLength = 2)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }


        //correo electronico
        [Display(Name = "Correo electrónico")]
        [EmailAddress(ErrorMessage = "La expresión no es válida para un email")]
        [StringLength(400, ErrorMessage = "Longitud máxima 400 caracteres")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido. No se permiten espacios en blanco")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }


        //telefono
        [Display(Name = "Número de celular")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Solo se permiten números en el número de celular")]
        [StringLength(15, ErrorMessage = "No se permiten más de 15 caracteres ni menos que 8", MinimumLength = 8)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido. No se permiten espacios en blanco")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
    }
}
