using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbobsCOM;
using ISap.Models;
namespace ISap.SAPB1
{
    class Invoice:DI
    {
        private Documents sapInvoice;

        public Invoice()
        {
            
        }

        public void newInvoice(Oinv invoice)
        {
            
            int errorCode;
            string errorMessage;
            if (!this.connect(out errorCode, out errorMessage))
            {
                String.Format("Errores durante la conexión {0}, {1}", errorCode.ToString(), errorMessage);
            }
            this.company.StartTransaction();
            sapInvoice = company.GetBusinessObject(BoObjectTypes.oInvoices);
            sapInvoice.CardCode = invoice.CardCode;
            sapInvoice.CardName = invoice.CardName;
            sapInvoice.DocDate = invoice.DocDate;
            sapInvoice.TaxDate = invoice.TaxDate;
            sapInvoice.DocDueDate = invoice.DocDueDate;
            foreach (Inv1 lines in invoice.Inv1s)
            { 
                
                sapInvoice.Lines.ItemCode = lines.ItemCode;
                sapInvoice.Lines.ItemDescription = lines.Dscription;
                sapInvoice.Lines.Quantity = double.Parse(lines.Quantity.ToString());
                sapInvoice.Lines.Price = double.Parse(lines.Price.ToString());
                sapInvoice.Lines.TaxCode = lines.TaxCode;
                sapInvoice.Lines.Add();
            }
            int result = sapInvoice.Add();
            if (result != 0)
            {
                company.GetLastError(out errorCode, out errorMessage);
                if (company.InTransaction)
                    company.EndTransaction(BoWfTransOpt.wf_RollBack);
                //return false;
            }
            else
            {
                company.GetNewObjectCode(out string obj);
                if (sapInvoice.GetByKey(int.Parse(obj)))
                {
                    invoice.DocEntry = sapInvoice.DocEntry;
                    invoice.DocNum = sapInvoice.DocNum;
                }
                company.EndTransaction(BoWfTransOpt.wf_Commit);
                if (company.Connected)
                    company.Disconnect();
            }
        }
    }
}
