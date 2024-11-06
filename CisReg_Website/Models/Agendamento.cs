namespace CisReg_Website.Models
{
    public class Agendamento
    {
        public string Hora { get; set; }
        public string Data { get; set; }
        public string Paciente { get; set; }
        public string CDSUS { get; set; }
        public List<string> Especialidades { get; set; }
    }
}
