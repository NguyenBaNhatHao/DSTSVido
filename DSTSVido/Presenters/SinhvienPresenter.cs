using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTSVido.Models;
using DSTSVido.Views;
using DSTSVido.Dtos;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Aspose.Cells;
using Aspose.Cells.Utility;
using Newtonsoft.Json.Linq;
using System.Data;


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
            this.view.Dropdowncblop += Dropdowncblop;
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
            diemdanhs = (reposity.GetByValue(this.view.Lop, this.view.Monhoc, this.view.Nguoitao, this.view.Khoahoc)).ToList();
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
        private void Dropdowncblop(object sender, EventArgs e)
        {
            reposity.GetByValue(this.view.Lop, this.view.Monhoc, this.view.Nguoitao, this.view.Khoahoc);
        }
        private void ExportExcel(object sender, EventArgs e)
        {
            try
            {
                var diemdanhs = new List<Diemdanh>();
                var HeaderDiemdanh = new List<DiemdanhHeaderSendDTO>();
                diemdanhs = (reposity.GetByValue(this.view.Lop, this.view.Monhoc, this.view.Nguoitao, this.view.Khoahoc)).ToList();
                HeaderDiemdanh = (reposity.GetByValueHeader(this.view.Lop, this.view.Monhoc, this.view.Nguoitao, this.view.Khoahoc)).ToList();
                var dataSearch = reposity.GetDiemdanh(diemdanhs[0]);
                var dataHeader = reposity.GetDiemdanhHeader(HeaderDiemdanh[0]);
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(dataSearch.Result, typeof(DataTable));
                DataTable hd = (DataTable)JsonConvert.DeserializeObject(dataHeader.Result, typeof(DataTable));
                Save_data_table_to_excel(dt, hd);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Save_data_table_to_excel(DataTable dt, DataTable hd)
        {
            int intHeaderLength = 3;
            int intColumn = 0;
            int intRow = 0;
            string Work_sheet_name = "DanhSach";
            string Report_Type = "Details";
            System.Reflection.Missing Default = System.Reflection.Missing.Value;

            //create the excel file
            //string FilePath = @"\\Excel" + DateTime.Now.ToString().Replace(":", "_" + ".xlsx");
            string FolderExcel = Application.StartupPath + @"\Excel";
            string FilePath = FolderExcel + @"\FormDiemdanh.xls";

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkbook;
            Microsoft.Office.Interop.Excel.Worksheet excelsheet;
            Microsoft.Office.Interop.Excel.Range excelCellRange;
            try
            {

                //start the application
                excel = new Microsoft.Office.Interop.Excel.Application();
                if (excel == null)
                {
                    Console.WriteLine("getting null values");
                }

                //for making excel visiable
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // creation a new work book
                excelworkbook = excel.Workbooks.Open(FilePath, Type.Missing, false, Type.Missing, Type.Missing,
            Type.Missing, true, Type.Missing, Type.Missing,
            true, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

                //excelsheet
                excelsheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkbook.ActiveSheet;
                excelsheet.Name = Work_sheet_name;

           
                // loop through each row and add the value to our sheet

                int rowcount = 4;
                foreach (DataRow datarowHeader in hd.Rows)
                {
                    rowcount += 1;

                    excelsheet.Cells.Font.Color = System.Drawing.Color.Black;
                    //khoinganh
                    excelsheet.Cells[4, 1] = hd.Columns[2].ColumnName+": "+ datarowHeader[2].ToString();
                    //hedaotao  
                    excelsheet.Cells[5, 1] = hd.Columns[5].ColumnName + ": " + datarowHeader[5].ToString();
                    
                    //monhoc
                    excelsheet.Cells[6, 1] = hd.Columns[3].ColumnName;
                    excelsheet.Cells[6, 3] = datarowHeader[3].ToString();

                    //lop
                    excelsheet.Cells[7, 1] = hd.Columns[1].ColumnName;
                    excelsheet.Cells[7,3] = datarowHeader[1].ToString();

                    //Tin chi
                    excelsheet.Cells[6, 16] = hd.Columns[4].ColumnName;
                    excelsheet.Cells[6, 21] = datarowHeader[4].ToString();
                    //Khoa
                    excelsheet.Cells[7, 16] = hd.Columns[0].ColumnName;
                    excelsheet.Cells[7, 21] = datarowHeader[0].ToString();

                    //Hoc ki
                    excelsheet.Cells[8, 1] = hd.Columns[6].ColumnName;
                    excelsheet.Cells[8, 3] = datarowHeader[6].ToString();

                    rowcount = 13;
                    foreach (DataRow datarow in dt.Rows)
                    {
                        excelsheet.Cells[rowcount, 3] = datarow[0].ToString();
                        excelsheet.Cells[rowcount, 2] = datarow[2].ToString();
                        excelsheet.Cells[rowcount, 4] = datarow[1].ToString();
                        excelsheet.Cells[rowcount, 5] = datarow[5].ToString();

                        rowcount += 1;
                    }

                    rowcount = 12;
                    int row = 13;
                    for (int i =12; i<dt.Columns.Count; i++)
                    {
                        excelsheet.Cells[rowcount, i-6] = dt.Columns[i].ColumnName;
                    }
                    foreach (DataRow datarow in dt.Rows)
                    {
                        for(int col = 12; col < dt.Columns.Count; col++)
                        {
                            excelsheet.Cells[row, col - 6] = datarow[col].ToString();
                        }
                        row++;
                    }

                    // now resize the columns
                    excelCellRange = excelsheet.Range[excelsheet.Cells[1, 1], excelsheet.Cells[rowcount, hd.Columns.Count]];
                    excelCellRange.EntireColumn.AutoFit();
                }
                //now save the work book and exit the ecel
                excelworkbook.SaveAs(FolderExcel+@"\"+this.view.Lop+@".xls");
                excelworkbook.Close(true,FilePath);
                excel.Quit();
                //  }
                MessageBox.Show(DialogResult.OK.ToString());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
        
            }
            finally
            {
                excelsheet = null;
                excelCellRange = null;
                excelworkbook = null;
            }
        }
    }
}
