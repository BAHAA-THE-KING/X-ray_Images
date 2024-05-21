
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using System;
using System.Windows.Forms;
namespace X_ray_Images.Classes
{
    public class PDF
    {

        public static bool Generate(string name, string illness, string illnessDescription, string status, string doctorName, DateTime date, DateTime nextReview, string diagnoses, string diagnosisDescription, string cure, string address, string phoneNumber)
        {
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;

                string uniqueFileName = $"PatientReport_{Guid.NewGuid()}.pdf";
                string filePath = Path.Combine("pdfs", uniqueFileName);

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(12).LineHeight(1.5f));

                        page.Header()
                            .Text("Patient Report")
                            .SemiBold().FontSize(24).FontColor(Colors.Blue.Medium)
                            .AlignCenter();

                        page.Content()
                            .PaddingVertical(1, Unit.Centimetre)
                            .Column(x =>
                            {
                                x.Spacing(25);

                                // Basic Info Section
                                x.Item().Text("Basic Information")
                                    .SemiBold().FontSize(18).FontColor(Colors.Black);
                                x.Item().Row(row =>
                                {
                                    row.RelativeItem().Column(column =>
                                    {
                                        column.Spacing(10);
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Name: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(name).FontColor(Colors.Grey.Darken1);
                                        });
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Illness: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(illness).FontColor(Colors.Grey.Darken1);
                                        });
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Illness Description: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(illnessDescription).FontColor(Colors.Grey.Darken1);
                                        });
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Status: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(status).FontColor(Colors.Grey.Darken1);
                                        });
                                    });
                                    row.RelativeItem().AlignRight().Column(column =>
                                    {
                                        column.Spacing(10);
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Supervised Doctor: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(doctorName).FontColor(Colors.Grey.Darken1);
                                        });
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Date: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(date.ToString("d_M_y")).FontColor(Colors.Grey.Darken1);
                                        });
                                        column.Item().Text(text =>
                                        {
                                            text.Span("Next Review: ").SemiBold().FontColor(Colors.Black);
                                            text.Span(nextReview.ToString("d_M_y")).FontColor(Colors.Grey.Darken1);
                                        });
                                    });
                                });

                                // Status Data Section
                                x.Item().Text("Status Data")
                                    .SemiBold().FontSize(18).FontColor(Colors.Black);
                                x.Item().Column(column =>
                                {
                                    column.Spacing(10);
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Diagnoses: ").SemiBold().FontColor(Colors.Black);
                                        text.Span(diagnoses).FontColor(Colors.Grey.Darken1);
                                    });
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Description: ").SemiBold().FontColor(Colors.Black);
                                        text.Span(diagnosisDescription).FontColor(Colors.Grey.Darken1);
                                    });
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Cure: ").SemiBold().FontColor(Colors.Black);
                                        text.Span(cure).FontColor(Colors.Grey.Darken1);
                                    });
                                });

                                // Communication Info Section
                                x.Item().Text("Communication Info")
                                    .SemiBold().FontSize(18).FontColor(Colors.Black);
                                x.Item().Column(column =>
                                {
                                    column.Spacing(10);
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Lives In: ").SemiBold().FontColor(Colors.Black);
                                        text.Span(address).FontColor(Colors.Grey.Darken1);
                                    });
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Phone Number: ").SemiBold().FontColor(Colors.Black);
                                        text.Span(phoneNumber).FontColor(Colors.Grey.Darken1);
                                    });
                                });
                            });

                        page.Footer()
                            .AlignCenter()
                            .Text(x =>
                            {
                                x.Span("Page ");
                                x.CurrentPageNumber();
                            });
                    });
                })
                .GeneratePdf(filePath);

                // MessageBox.Show($"PDF generated successfully at: {filePath}", "Success!");
                return true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.GetBaseException().Message, "Generating PDF file failed!");
                return false;
            }
        }
    }
}