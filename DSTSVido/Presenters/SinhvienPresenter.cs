using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTSVido.Models;
using DSTSVido.Views;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Aspose.Cells;
using Aspose.Cells.Utility;

namespace DSTSVido.Presenters
{
    public class SinhvienPresenter
    {
        private ISinhvienView view;
        private ISinhvienReposity reposity;
        private BindingSource sinhvienbindingSource;
        private BindingSource diemdanhbindingSource;
        private IEnumerable<Sinhvien> SinhvienList;
        private IEnumerable<Diemdanh> DiemdanhList;

        public SinhvienPresenter(ISinhvienView view, ISinhvienReposity reposity)
        {
            this.sinhvienbindingSource = new BindingSource();
            this.diemdanhbindingSource = new BindingSource();
            this.view = view;
            this.reposity = reposity;

            this.view.ImportDataEvent += ImportData;
            //this.view.SearchStatus += SeerchStatus;
            this.view.UpdateEditData += UpdateData;
            this.view.ExportExcel += ExportExcel;
            this.view.Searchdd += SearchDiemdanh;
            //Set sinhvien blindind source
            this.view.SetSinhVienListBindingSource(sinhvienbindingSource);
            this.view.SetDiemDanhListBindingSource(diemdanhbindingSource);
            
            //Load sinhvien
            LoadAllTrungTuyenList();
            //Show view
            this.view.Show();
        }
        private void SearchDiemdanh(object sender, EventArgs e)
        {
            var diemdanhs = new List<Diemdanh>();
            diemdanhs = (reposity.GetByValue(this.view.Lop, this.view.Monhoc, this.view.Nguoitao)).ToList();
            var dataSearch = reposity.GetDiemdanh(diemdanhs[0]);
            DiemdanhList = JsonConvert.DeserializeObject<IEnumerable<Diemdanh>>(dataSearch.Result);
            diemdanhbindingSource.DataSource = DiemdanhList;
        }
        private void ImportData(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<int> cells = new List<int>();
                string filename = ofd.FileName;
                // Get the input file path
                var inputFile = new FileInfo(filename);

                // Create an instance of Fast Excel
                using (FastExcel.FastExcel fastExcel = new FastExcel.FastExcel(inputFile, true))
                {
                    foreach (var worksheet in fastExcel.Worksheets)
                    {
                        Console.WriteLine(string.Format("Worksheet Name:{0}, Index:{1}", worksheet.Name, worksheet.Index));

                        //To read the rows call read
                        worksheet.Read();
                        var rows = worksheet.Rows.ToList();
                        foreach (var cell in rows[0].Cells)
                        {
                            if (cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"SV_ID") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"TÊN") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"NGÀY") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"THÁNG") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"NĂM") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"Hệ ĐÀO TẠO") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"NGÀNH") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"HÌNH THỨC") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"TÌNH TRẠNG") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"KẾT QUẢ") ||
                                cell.Value.ToString()
                                .ToUpper()
                                .Contains(@"EMAIL")
                                )
                            {
                                cells.Add(cell.ColumnNumber);
                            }
                        }
                        rows.RemoveAt(0);
                        int count = 0;
                        foreach (var row in rows)
                        {
                            Sinhvien model = new Sinhvien();
                            model.sv_id = row.Cells.ToArray()[0].Value.ToString();
                            model.sv_name = row.Cells.ToArray()[1].Value.ToString();
                            model.sv_ngaysinh = row.Cells.ToArray()[2].Value.ToString() + "/"+ row.Cells.ToArray()[3].Value.ToString() + "/"+ row.Cells.ToArray()[4].Value.ToString();
                            model.sv_hedaotao = row.Cells.ToArray()[5].Value.ToString();
                            model.sv_nganh = row.Cells.ToArray()[6].Value.ToString();
                            model.sv_hinhthuc = row.Cells.ToArray()[7].Value.ToString();
                            model.sv_tinhtrang = row.Cells.ToArray()[8].Value.ToString();
                            model.sv_ketqua = row.Cells.ToArray()[9].Value.ToString();
                            //bug in here
                            if (String.IsNullOrWhiteSpace(model.sv_id))
                            {
                                MessageBox.Show(String.Format("Import {0} rows", count));
                                return;
                            }
                            reposity.InsertData(model);
                            count++;
                        }
                        MessageBox.Show(String.Format("Import {0} rows", count));
                        LoadAllTrungTuyenList();
                        //Do something with rows
                        Console.WriteLine(string.Format("Worksheet Rows:{0}", rows.Count()));
                    }
                }
            }
        }
        private void LoadAllTrungTuyenList()
        {
            SinhvienList = JsonConvert.DeserializeObject<IEnumerable<Sinhvien>>(reposity.GetAll().Result);
            sinhvienbindingSource.DataSource = SinhvienList;
        }
        private void UpdateData(object sender, EventArgs e)
        {
            
            MessageBox.Show(DialogResult.OK.ToString());
        }
        private void ExportExcel(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];

            // Read JSON File
            string jsonInput = File.ReadAllText("Data.json");

            // Set JsonLayoutOptions
            JsonLayoutOptions options = new JsonLayoutOptions();
            options.ArrayAsTable = true;

            // Import JSON Data
            JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);

            // Save Excel file
            workbook.Save("Import-Data-JSON-To-Excel.xlsx");
            MessageBox.Show(DialogResult.OK.ToString());
        }
    }
}
