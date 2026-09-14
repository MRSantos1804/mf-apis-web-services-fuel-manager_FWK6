using mf_apis_web_services_fuel_manager_FWK6.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_fuel_manager_FWK6.Models
{
    [Table("VeiculoUsuarios")]
    public class VeiculoUsuarios
    {
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}