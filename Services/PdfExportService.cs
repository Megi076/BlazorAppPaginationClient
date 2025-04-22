/*using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using BlazorAppPaginationClient.Models;
using System.Collections.Generic;

namespace BlazorAppPaginationClient.Services
{
    public class PdfExportService
    {
        public byte[] GeneratePdf(List<TaxiRecord> taxiRecords)
        {
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(595, 842); // Големината на A4 во пиксели
                    page.Margin(50);

                    page.Content().Column(col =>
                    {
                        col.Item().Text("Taxi Rides Data", TextStyle.Default.Size(20).Bold());
                        col.Item().PaddingTop(20).Table(table =>
                        {
                            // Додавање на хедер
                            table.Header(header =>
                            {
                                header.Cell().Text("Medallion");
                                header.Cell().Text("Hash License");
                                header.Cell().Text("Pickup Time");
                                header.Cell().Text("Drop-off Time");
                                header.Cell().Text("Duration");
                                header.Cell().Text("Distance");
                                header.Cell().Text("Pickup Longitude");
                                header.Cell().Text("Pickup Latitude");
                                header.Cell().Text("Drop-off Longitude");
                                header.Cell().Text("Drop-off Latitude");
                                header.Cell().Text("Payment Type");
                                header.Cell().Text("Fare Amount");
                                header.Cell().Text("Surcharge");
                                header.Cell().Text("Tax");
                                header.Cell().Text("Tip Amount");
                                header.Cell().Text("Tolls Amount");
                                header.Cell().Text("Total Amount");
                            });

                            // Додавање на редови
                            foreach (var record in taxiRecords)
                            {
                                table.Cell().Text(record.medallion);
                                table.Cell().Text(record.hashLicense);
                                table.Cell().Text(record.pickupTime.ToString());
                                table.Cell().Text(record.dropOffTime.ToString());
                                table.Cell().Text(record.duration.ToString());
                                table.Cell().Text(record.distance.ToString());
                                table.Cell().Text(record.pLongitude.ToString());
                                table.Cell().Text(record.pLatitude.ToString());
                                table.Cell().Text(record.dLongitude.ToString());
                                table.Cell().Text(record.dLatitude.ToString());
                                table.Cell().Text(record.paymentType);
                                table.Cell().Text(record.fareAmount.ToString());
                                table.Cell().Text(record.surcharge.ToString());
                                table.Cell().Text(record.tax.ToString());
                                table.Cell().Text(record.tipAmount.ToString());
                                table.Cell().Text(record.tollsAmount.ToString());
                                table.Cell().Text(record.totalAmount.ToString());
                            }
                        });
                    });
                });
            });

            return document.GeneratePdf(); // Генерирање на PDF во байт формат
        }
    }
}
*/