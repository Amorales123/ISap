using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISap.Helpers
{
    public static class TCService
    {
        static TCBanGuat.TipoCambioSoapClient tipoCambio;

        static TCService()
        {
            tipoCambio = new global::TCBanGuat.TipoCambioSoapClient(global::TCBanGuat.TipoCambioSoapClient.EndpointConfiguration.TipoCambioSoap);
        }
        /// <summary>
        /// Retorna el Tipo de Cambio del Día
        /// </summary>
        /// <returns></returns>
        public static TipoCambio TcNow() => new TipoCambio() { 
            fecha = tipoCambio.TipoCambioDia().CambioDolar.FirstOrDefault().fecha, 
            tcVenta = tipoCambio.TipoCambioDia().CambioDolar.FirstOrDefault().referencia };
       
        /// <summary>
        /// Retorna tipo de cambio desde la fecha solicitada hasta el día actual
        /// </summary>
        /// <param name="date"> Formato: dd/mm/yyyy</param>
        /// <returns></returns>
        public static List<TipoCambio> TcToDate(String date)
        {
            List<TipoCambio> tc = new List<TipoCambio>();
            foreach (TCBanGuat.Var var in tipoCambio.TipoCambioFechaInicial(date).Vars)
            {
                tc.Add(new TipoCambio() { fecha = var.fecha, tcCompra = var.compra, tcVenta = var.venta });                
            }
            return tc;
        }
    }

}
