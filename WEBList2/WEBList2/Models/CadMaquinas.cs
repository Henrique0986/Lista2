using System.ComponentModel.DataAnnotations;

namespace WEBList2.Models
{
    public class CadMaquinas
    {
        [Key]
        public int idMaquinas { get; set; }
        public string Maquina { get; set; }
    }
}
