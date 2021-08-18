using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Pages.Statement.ViewModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;
using System.Web;
using System.Text;
using OfficeOpenXml;
using System.Drawing;

namespace PinhuaMaster.Pages.Statement
{
    public class DetailsModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;

        public DetailsModel(PinhuaContext pinhuaContext)
        {
            _pinhuaContext = pinhuaContext;
        }

        public string Id { get; set; }
        public IEnumerable<DbQuery_对账汇总> StatementData { get; set; }

        public void OnGet(string Id)
        {
            this.Id = Id;
            StatementData = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == Id).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
        }

        public IActionResult OnGetAjax(string Id)
        {
            var dto = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == Id).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            //EF Core中默认为驼峰样式序列化处理key
            //settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //使用默认方式，不更改元数据的key的大小写
            settings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();

            return new JsonResult(dto, settings);
        }

        public IActionResult OnGetExportExcel(string Id)
        {
            this.Id = Id;
            var customer = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Id);
            StatementData = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == Id).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("Sheet1");
            var fontTitle = workbook.CreateFont();
            fontTitle.FontName = "微软雅黑";
            fontTitle.FontHeightInPoints = 12;
            fontTitle.IsBold = true;
            var fontBody = workbook.CreateFont();
            fontBody.FontName = "微软雅黑";
            fontBody.FontHeightInPoints = 10;
            var styleTitle = workbook.CreateCellStyle();
            styleTitle.SetFont(fontTitle);
            var styleBody = workbook.CreateCellStyle();
            styleBody.SetFont(fontBody);

            // Add Title
            var rowIndex = 0;
            var row = sheet.CreateRow(rowIndex);
            for (var i = 0; i != 20; i++)
            {
                row.CreateCell(i);
            }
            var titleCell = row.GetCell(0);
            titleCell.SetCellValue(customer.单位名称);
            titleCell.CellStyle = styleTitle;
            rowIndex++;
            // Add header labels
            row = sheet.CreateRow(rowIndex);
            row.CreateCell(0).SetCellValue("日期");
            row.CreateCell(1).SetCellValue("业务描述");
            row.CreateCell(2).SetCellValue("产品编号");
            row.CreateCell(3).SetCellValue("产品描述");
            row.CreateCell(4).SetCellValue("规格");
            row.CreateCell(5).SetCellValue("片数");
            row.CreateCell(6).SetCellValue("数量");
            row.CreateCell(7).SetCellValue("单位");
            row.CreateCell(8).SetCellValue("单价");
            row.CreateCell(9).SetCellValue("金额");
            for (var i = 0; i != 10; i++)
            {
                var cell = row.GetCell(i);
                cell.CellStyle = styleBody;
            }
            rowIndex++;
            // Add data rows
            foreach (var data in StatementData)
            {
                row = sheet.CreateRow(rowIndex);
                row.CreateCell(0).SetCellValue(data.OrderDate.Value.ToString("yyyy-MM-dd"));
                row.CreateCell(1).SetCellValue(data.MovementTypeDescription);
                row.CreateCell(2).SetCellValue(data.ItemId);
                row.CreateCell(3).SetCellValue(data.Description);
                row.CreateCell(4).SetCellValue(data.Specification);
                row.CreateCell(5).SetCellValue((double)(data.Qty ?? 0));
                row.CreateCell(6).SetCellValue((double)(data.UnitQty ?? 0));
                row.CreateCell(7).SetCellValue(data.Unit);
                row.CreateCell(8).SetCellValue((double)(data.Price ?? 0));
                row.CreateCell(9).SetCellValue((double)(data.Amount ?? 0));
                for (var i = 0; i != 10; i++)
                {
                    var cell = row.GetCell(i);
                    cell.CellStyle = styleBody;
                }
                rowIndex++;
            }

            AutoColumnWidth1(sheet);
            //using (var fileData = new FileStream("C:\\Statement.xls", FileMode.Create))
            //{
            //    workbook.Write(fileData);
            //}
            using (var exportData = new MemoryStream())
            {
                workbook.Write(exportData);
                var saveAsFileName = $"对帐单，{customer.单位名称}-{DateTime.Now.ToString("yyyyMMddHHmmss")}.xls";
                var fileExt = Path.GetExtension(saveAsFileName);
                var provider = new FileExtensionContentTypeProvider();
                //Response.Headers["Content-Type"] = provider.Mappings[fileExt];
                //Response.Headers["Content-Disposition"] = $"attachment; filename={saveAsFileName}{fileExt}";
                //Response.Headers.ContentLength = exportData.Length;
                //Response.Body.Write(exportData.GetBuffer(), 0, (int)exportData.Length);
                //Response.Body.Flush();

                return File(exportData.GetBuffer(), provider.Mappings[fileExt], saveAsFileName);
            }
        }
        public void AutoColumnWidth1(ISheet sheet)
        {
            var firstRow = sheet.GetRow(0);
            if (firstRow == null)
                return;
            var lastCol = firstRow.LastCellNum;
            for (int col = 0; col <= lastCol; col++)
            {
                sheet.AutoSizeColumn(col);//自适应宽度，但是其实还是比实际文本要宽
                //int columnWidth = sheet.GetColumnWidth(col) / 256;//获取当前列宽度
                //for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
                //{
                //    IRow row = sheet.GetRow(rowIndex);
                //    ICell cell = row.GetCell(col);
                //    int contextLength = Encoding.UTF8.GetBytes(cell.ToString()).Length;//获取当前单元格的内容宽度
                //    columnWidth = columnWidth < contextLength ? contextLength : columnWidth;

                //}
                //sheet.SetColumnWidth(col, columnWidth * 256);
            }
        }

        public void AutoColumnWidth2(ISheet sheet)
        {
            var firstRow = sheet.GetRow(0);
            if (firstRow == null)
                return;
            var lastCol = firstRow.LastCellNum;
            for (int col = 0; col <= lastCol; col++)
            {
                //sheet.AutoSizeColumn(col);//自适应宽度，但是其实还是比实际文本要宽
                int columnWidth = sheet.GetColumnWidth(col) / 256;//获取当前列宽度
                for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
                {
                    IRow row = sheet.GetRow(rowIndex);
                    ICell cell = row.GetCell(col);
                    int contextLength = Encoding.UTF8.GetBytes(cell.ToString()).Length;//获取当前单元格的内容宽度
                    columnWidth = columnWidth < contextLength ? contextLength : columnWidth;
                }
                sheet.SetColumnWidth(col, columnWidth * 256);
            }
        }
        public IActionResult OnGetExportExcelEPPlus(string Id)
        {
            this.Id = Id;
            var customer = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Id);
            StatementData = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == Id).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
            using (ExcelPackage pck = new ExcelPackage())
            {
                //Create the worksheet
                string sheetName = "Sheet1";
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add(sheetName);
                ws.Cells.Style.Font.Name = "Microsoft YaHei";
                ws.Cells.Style.Font.Size = 11;
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                ws.Cells[1, 1].Value = $"对帐单，{customer.单位名称} - {DateTime.Now.ToString("yyyyMMddHHmmss")}";
                ws.Row(1).Height = 40;
                ws.Row(1).Style.Font.Size = 12;
                ws.Cells[1, 1, 1, 11].Merge = true;
                ws.Cells[1, 1, 1, 11].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[2, 1].Value = "日期";
                ws.Cells[2, 2].Value = "业务描述";
                ws.Cells[2, 3].Value = "备注";
                ws.Cells[2, 4].Value = "产品编号";
                ws.Cells[2, 5].Value = "产品描述";
                ws.Cells[2, 6].Value = "规格";
                ws.Cells[2, 7].Value = "片数";
                ws.Cells[2, 8].Value = "数量";
                ws.Cells[2, 9].Value = "单位";
                ws.Cells[2, 10].Value = "单价";
                ws.Cells[2, 11].Value = "金额";
                ws.Row(2).Height = 30;
                ws.Row(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                ws.Row(2).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                ws.Cells[2, 1, 2, 11].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[2, 1, 2, 11].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 246, 235));
                ws.Cells[2, 1, 2, 11].AutoFilter = true;
                var rowNum = 3;
                foreach (var data in StatementData)
                {
                    ws.Row(rowNum).Height = 20;
                    ws.Row(rowNum).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    ws.Cells[rowNum, 1].Value = data.OrderDate.Value.ToString("yyyy-MM-dd");
                    ws.Cells[rowNum, 2].Value = data.MovementTypeDescription;
                    ws.Cells[rowNum, 3].Value = data.Remarks;
                    ws.Cells[rowNum, 4].Value = data.ItemId;
                    ws.Cells[rowNum, 5].Value = data.Description;
                    ws.Cells[rowNum, 6].Value = data.Specification;
                    ws.Cells[rowNum, 6].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;
                    ws.Cells[rowNum, 7].Value = data.Qty;
                    ws.Cells[rowNum, 7].Style.Numberformat.Format = "0.00";
                    ws.Cells[rowNum, 8].Value = data.UnitQty;
                    ws.Cells[rowNum, 8].Style.Numberformat.Format = "0.00";
                    ws.Cells[rowNum, 9].Value = data.Unit;
                    ws.Cells[rowNum, 10].Value = data.Price;
                    ws.Cells[rowNum, 10].Style.Numberformat.Format = "0.00";
                    ws.Cells[rowNum, 11].Value = data.Amount;
                    ws.Cells[rowNum, 11].Style.Numberformat.Format = "0.00";
                    if (data.Amount < 0)
                    {
                        //ws.Row(rowNum).Style.Font.Color.SetColor(ColorTranslator.FromHtml("#A94442"));
                    }
                    rowNum++;
                }
                if (StatementData.Count() > 0)
                {
                    ws.Cells[rowNum, 11].Formula = $"SUM(K3:K{StatementData.Count() + 2})";
                    ws.Cells[rowNum, 11].Style.Numberformat.Format = "0.00";
                    ws.Row(rowNum).Height = 25;
                    ws.Row(rowNum).Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    ws.Cells[rowNum, 1, rowNum, 11].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    ws.Cells[rowNum, 1, rowNum, 11].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 246, 235));
                }
                var allCells = ws.Cells[$"A1:K{rowNum}"];
                allCells.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCells.Style.Border.Left.Color.SetColor(Color.FromArgb(166, 166, 166));
                allCells.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCells.Style.Border.Right.Color.SetColor(Color.FromArgb(166, 166, 166));
                allCells.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCells.Style.Border.Top.Color.SetColor(Color.FromArgb(166, 166, 166));
                allCells.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                allCells.Style.Border.Bottom.Color.SetColor(Color.FromArgb(166, 166, 166));
                ws.Calculate();
                ws.Cells.AutoFitColumns();
                ws.View.FreezePanes(3, 1);

                var cfAddress = new ExcelAddress(3, 1, StatementData.Count() + 2, 11);
                var cfRule1 = ws.ConditionalFormatting.AddExpression(cfAddress);
                cfRule1.Formula = "$K3<0";
                cfRule1.Style.Font.Color.Color = ColorTranslator.FromHtml("#A94442"); // text-danger
                //var cfRule2 = ws.ConditionalFormatting.AddExpression(cfAddress);
                //cfRule2.Formula = "$J3>=0";
                //cfRule2.Style.Font.Color.Color = Color.FromArgb(0x337AB7); // text-primary

                var saveAsFileName = $"对帐单，{customer.单位名称}-{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                var fileExt = Path.GetExtension(saveAsFileName);
                var provider = new FileExtensionContentTypeProvider();
                return File(pck.GetAsByteArray(), provider.Mappings[fileExt], saveAsFileName);
            }
        }
        public IActionResult OnGetExportExcelEPPlus2(string Id)
        {
            this.Id = Id;
            var customer = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Id);
            StatementData = _pinhuaContext.myView_对账_汇总.Where(p => p.CustomerId == Id).OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ThenBy(p => p.ItemId).ToList();
            using (ExcelPackage pck = new ExcelPackage(new FileInfo("epplus_template.xlsx"), new FileInfo("epplus_template.xlsx")))
            {
                //Create the worksheet
                string sheetName = "Sheet1";
                ExcelWorksheet ws = pck.Workbook.Worksheets[sheetName];
                ws.Cells.Style.Font.Name = "Microsoft YaHei";
                ws.Cells.Style.Font.Size = 10;
                //ws.InsertRow()
                //Load the datatable into the sheet, starting from cell A1. Print the column names on row 1
                //ws.Cells["A1"].LoadFromCollection<DbQuery_对账汇总>(StatementData);
                ws.Cells[1, 1].Value = $"对帐单，{customer.单位名称} - {DateTime.Now.ToString("yyyyMMddHHmmss")}";
                var rowNum = 3;
                ws.InsertRow(rowNum + 1, StatementData.Count() - 1);
                foreach (var data in StatementData)
                {
                    ws.Cells[rowNum, 1].Value = data.OrderDate.Value.ToString("yyyy-MM-dd");
                    ws.Cells[rowNum, 2].Value = data.MovementTypeDescription;
                    ws.Cells[rowNum, 3].Value = data.ItemId;
                    ws.Cells[rowNum, 4].Value = data.Description;
                    ws.Cells[rowNum, 5].Value = data.Specification;
                    ws.Cells[rowNum, 6].Value = data.Qty;
                    ws.Cells[rowNum, 7].Value = data.UnitQty;
                    ws.Cells[rowNum, 8].Value = data.Unit;
                    ws.Cells[rowNum, 9].Value = data.Price;
                    ws.Cells[rowNum, 10].Value = data.Amount;
                    rowNum++;
                }
                ws.Cells.AutoFitColumns();
                var saveAsFileName = $"对帐单，{customer.单位名称}-{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                var fileExt = Path.GetExtension(saveAsFileName);
                var provider = new FileExtensionContentTypeProvider();
                return File(pck.GetAsByteArray(), provider.Mappings[fileExt], saveAsFileName);
            }
        }

    }
}