namespace ServiciosGubernamentales2.Controllers
{
    public class Predio
    {

        public Predio(double PreFactorLluvia, double PreFactorHumedad, double PreFactorResequedad, int PreHectareas, int PreTipoSuelo)
        {
            this.PreFactorLluvia = PreFactorLluvia;
            this.PreFactorHumedad = PreFactorHumedad;
            this.PreFactorResequedad = PreFactorResequedad;
            this.PreHectareas = PreHectareas;
            this.PreTipoSuelo = PreTipoSuelo;
        }

        public double PreFactorLluvia { get; set; }
        public double PreFactorHumedad { get; set; }
        public double PreFactorResequedad { get; set; }
        public int PreHectareas { get; set; }
        public int PreTipoSuelo { get; set; }
    }
}