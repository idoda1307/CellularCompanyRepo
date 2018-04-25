using Autofac;
using BL.ModulesRegistration;
using Common.Interfaces;
using Common.Interfaces.RepositoryInterfaces;
using Common.Models;
using DAL;
using DAL.Models;
using DAL.Repositories;
using Dtos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.GroupManagers.Managers
{
    public class InvoiceManager
    {
        private IContainer GetContainer()
        {
            return ModulesRegistrations.RegisterInvoiceModule();
        }

        public void ExportDataToExcel()
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");
                
                List<string[]> headerRow = new List<string[]>()
                {
                 new string[] { "Line", "Permanent Billings", "Changed Billings", "Packages Use" }
                };
                string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                var excelWorksheet = excel.Workbook.Worksheets["Worksheet1"];
                excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);

                FileInfo excelFile = new FileInfo(@"C:\Users\idoda\Desktop\MonthlyBilling\test.xlsx");
                excel.SaveAs(excelFile);
            }
        }


        //public List<ClientDto> GetClients()
        //{
        //    List<ClientDto> clients = _manager.GetClients();
        //    return clients;
        //}

        //public List<LineDto> GetLines()
        //{
        //    List<LineDto> lines = new List<LineDto>();
        //    foreach (var item in _line.GetEntities())
        //    {
        //        lines.Add(ModelExtensions.ToDto(item));
        //    }
        //    return lines;
        //}

        //public void AddCall(CallsDto call)
        //{
        //    CallsEntity entity = ModelExtensions.ToModel(call);
        //    _calls.CreateEntity(entity);
        //}

        //public void AddSMSs(SMSDto sms)
        //{
        //    SMSEntity entity = ModelExtensions.ToModel(sms);
        //    _smss.CreateEntity(entity);
        //}
    }
}