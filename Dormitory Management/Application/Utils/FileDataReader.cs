using System.Data;
using System.Globalization;
using CsvHelper;
using OfficeOpenXml;

namespace Application.Utils;

public class FileDataReader
{
    public DataSet ReadFileToDataSet(Stream fileStream, string fileType)
    {
        var dataSet = new DataSet();

        if (fileType.Equals("csv", StringComparison.OrdinalIgnoreCase))
        {
            dataSet.Tables.Add(ReadCsvToDataTable(fileStream));
        }
        else if (fileType.Equals("xlsx", StringComparison.OrdinalIgnoreCase))
        {
            dataSet = ReadExcelToDataSet(fileStream);
        }

        return dataSet;
    }

    private DataTable ReadCsvToDataTable(Stream fileStream)
    {
        var dataTable = new DataTable();
        using var reader = new StreamReader(fileStream);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        using var dr = new CsvDataReader(csv);
        dataTable.Load(dr);

        return dataTable;
    }

    private DataSet ReadExcelToDataSet(Stream fileStream)
    {
        var dataSet = new DataSet();
        using var package = new ExcelPackage(fileStream);
        foreach (var worksheet in package.Workbook.Worksheets)
        {
            var dataTable = new DataTable(worksheet.Name);
            foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
            {
                dataTable.Columns.Add(firstRowCell.Text);
            }

            for (var rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
            {
                var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                var row = dataTable.NewRow();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
                dataTable.Rows.Add(row);
            }
            dataSet.Tables.Add(dataTable);
        }

        return dataSet;
    }
}