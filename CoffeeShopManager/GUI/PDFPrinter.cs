using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public static class PDFPrinter
    {
        public static string PrintReceipt(DTO_Receipt rec)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File | *.pdf";
            save.DefaultExt = "pdf";
            if (Properties.Settings.Default.ReceiptSaveFileLocation != string.Empty && Directory.Exists(Properties.Settings.Default.ReceiptSaveFileLocation))
            {
                save.InitialDirectory = Properties.Settings.Default.ReceiptSaveFileLocation;
            }
            else
            {
                MessageBox.Show("Because you haven't selected a save file location yet, the default location of the save dialog will be Desktop.",
                    "Default save location not selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                save.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            }

            if (save.ShowDialog() == DialogResult.OK)
            {
                // Initialize document & stuff
                Document doc = new Document(PageSize.A7, 7.5f, 7.5f, 10f, 10f);
                var writer = PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                iTextSharp.text.Font unifont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 7f);
                System.Drawing.Image coffeeCup = GUI.Properties.Resources.coffeeflat;
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(coffeeCup, System.Drawing.Imaging.ImageFormat.Png);

                // Shop info
                PdfPTable headerTable = new PdfPTable(1);
                PdfPCell imgCell = new PdfPCell(img, true);
                imgCell.Border = 0;
                imgCell.HorizontalAlignment = 1;
                headerTable.AddCell(imgCell);
                List<string> headerTexts = new List<string>();
                headerTexts.Add(rec.Shop.ShopName);
                if (rec.Shop.ShopAddress != null)
                {
                    headerTexts.Add($"Address: {rec.Shop.ShopAddress}");
                }
                if (rec.Shop.Phone != null)
                {
                    headerTexts.Add($"Phone: {rec.Shop.Phone}");
                }
                foreach (var text in headerTexts)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(text, unifont));
                    cell.Border = 0;
                    cell.HorizontalAlignment = 1;
                    headerTable.AddCell(cell);
                }

                // Receipt info
                PdfPTable metaInfoTable = new PdfPTable(2);
                metaInfoTable.SpacingBefore = metaInfoTable.SpacingAfter = 5f;
                List<string> metaTexts = new List<string>();
                metaTexts.Add($"Receipt No: {rec.Id}");
                if (rec.Employee != null)
                {
                    metaTexts.Add($"Employee No: {rec.Employee.Id}");
                }
                else
                {
                    metaTexts.Add($"Employee No: ");
                }
                metaTexts.Add(rec.DateOfPayMent.ToString("dd/MM/yyyy hh:mm tt"));
                metaTexts.Add($"Customer No: {rec.Customer.Id}");

                for (int i = 0; i < metaTexts.Count; ++i)
                {
                    var cell = new PdfPCell(new Phrase(metaTexts[i], unifont));
                    cell.Border = 0;
                    if (i % 2 == 0)
                    {
                        cell.HorizontalAlignment = 0;
                    }
                    else
                    {
                        cell.HorizontalAlignment = 2;
                    }
                    if (i == 2 || i == 3)
                    {
                        cell.BorderWidthBottom = 0.5f;
                    }
                    metaInfoTable.AddCell(cell);
                }

                // Receipt details
                PdfPTable detailsTable = new PdfPTable(3);
                float[] widths = { 1f, 3f, 2f };
                detailsTable.SetWidths(widths);
                detailsTable.SpacingAfter = 1f;
                string[] detailsTableHeader = { "Qty", "Product", "Total Price" };
                foreach (var text in detailsTableHeader)
                {
                    var cell = new PdfPCell(new Phrase(text, unifont));
                    cell.Border = 0;
                    cell.HorizontalAlignment = 0;
                    detailsTable.AddCell(cell);
                }

                List<string> details = new List<string>();
                foreach (var detail in rec.Items)
                {
                    details.Add(detail.Quantity.ToString());
                    details.Add(detail.Product.Name);
                    details.Add($"${detail.TotalPrice}");
                }
                for (int i = 0; i < details.Count; ++i)
                {
                    var cell = new PdfPCell(new Phrase(details[i], unifont));
                    cell.Border = 0;
                    if (i % 3 == 0 || (i - 2) % 3 == 0)
                    {
                        cell.HorizontalAlignment = 2;
                    }
                    else
                    {
                        cell.HorizontalAlignment = 0;
                    }
                    detailsTable.AddCell(cell);
                }

                // Line
                PdfPTable theLine = new PdfPTable(2);
                float[] sumWidths = { 2f, 1f };
                theLine.SpacingBefore = theLine.SpacingAfter = 5f;
                theLine.SetWidths(sumWidths);
                PdfPCell cellLine = new PdfPCell(new Phrase(string.Empty, unifont));
                cellLine.Border = 0;
                theLine.AddCell(cellLine);
                cellLine.BorderWidthTop = 0.5f;
                theLine.AddCell(cellLine);

                // Summary
                PdfPTable sumTable = new PdfPTable(2);
                sumTable.SetWidths(sumWidths);
                string[] summary = { "Subtotal:", $"${string.Format("{0:0.00}", rec.Total / (1m - rec.Discount))}",
                    "Discount:", $"{string.Format("{0:0.00}", rec.Discount * 100)}%", 
                    "Grand Total:", $"${string.Format("{0:0.00}", rec.Total)}", " ", " ", 
                    "Cash:", $"${string.Format("{0:0.00}", rec.Cash)}", "Change:", $"${string.Format("{0:0.00}", rec.Change)}" };
                for (int i = 0; i < summary.Length; ++i)
                {
                    PdfPCell cell;
                    if (i == summary.Length - 7)
                    {
                        cell = new PdfPCell(new Phrase(summary[i], FontFactory.GetFont("Courier", 7f, iTextSharp.text.Font.BOLD)));
                    }
                    else
                    {
                        cell = new PdfPCell(new Phrase(summary[i], unifont));
                    }
                    cell.Border = 0;
                    cell.HorizontalAlignment = 2;
                    
                    sumTable.AddCell(cell);
                }

                // Final lines
                PdfPTable finTable = new PdfPTable(1);
                finTable.SpacingBefore = 10f;
                PdfPCell finCell = new PdfPCell(new Phrase("THANK YOU FOR VISITING!", unifont));
                finCell.Border = 0;
                finCell.HorizontalAlignment = 1;
                finTable.AddCell(finCell);

                // Add to document
                doc.Open();
                doc.Add(headerTable);
                doc.Add(metaInfoTable);
                doc.Add(detailsTable);
                doc.Add(theLine);
                doc.Add(sumTable);
                doc.Add(finTable);
                doc.Close();
                writer.Close();

                // Save path for later ops
                Properties.Settings.Default.ReceiptSaveFileLocation = Path.GetDirectoryName(save.FileName);
                Properties.Settings.Default.Save();

                return save.FileName;
            }
            else
            {
                return null;
            }
        }
    }
}
