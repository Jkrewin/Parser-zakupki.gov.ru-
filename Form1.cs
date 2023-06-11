using Parser_zakupki.gov.ru_.Xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO.Compression;
using System.Net.NetworkInformation;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Diagnostics;


// Нужен NuGet = System.IO.Compression.ZipFile
// Нужен NuGet  = DocumentFormat.OpenXml


namespace Parser_zakupki.gov.ru_
{
    public partial class Form1 : Form
    {
        private List<EpNotificationStruct> AllepNotifications;
        private List<int> DaySelect = new List<int>();
        private readonly Dictionary<EpNotificationStruct.PlacingWayEnum, System.Drawing.Color> DicColor = new Dictionary<EpNotificationStruct.PlacingWayEnum, System.Drawing.Color>();

        private string TargetFtp { get => $"ftp://ftp.zakupki.gov.ru/fcs_regions/{ComBox1.Text}/notifications/currMonth/"; }       
        private string DirTmp
        {
            get
            {
                string tmp = Path.GetTempPath() + "ZipTemp\\";
                if (Directory.Exists(tmp) == false) { Directory.CreateDirectory(tmp); }
                return tmp;
            }
        }

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            ComBox1.SelectedIndex = 55;

            DGridView1.Columns.Add("id", "ID");
            DGridView1.Columns[0].Width = 100;
            DGridView1.Columns[0].ReadOnly = true;

            DGridView1.Columns.Add("purchaseNumber", "№ извещения");
            DGridView1.Columns[1].Width = 180;
            DGridView1.Columns[1].ReadOnly = true;

            DGridView1.Columns.Add("publishDTInEIS", "Дата");
            DGridView1.Columns[2].Width = 100;
            DGridView1.Columns[2].ReadOnly = true;

            DGridView1.Columns.Add("ETP_name", "ЭТП");
            DGridView1.Columns[3].Width = 150;
            DGridView1.Columns[3].ReadOnly = true;

            DGridView1.Columns.Add("purchaseObjectInfo", "Название");
            DGridView1.Columns[4].Width = 600;
            DGridView1.Columns[4].ReadOnly = true;

            DGridView1.Columns.Add("maxPrice", "Н/Цена");
            DGridView1.Columns[5].Width = 100;
            DGridView1.Columns[5].ReadOnly = true;

            DGridView1.Columns.Add("postAddress", "Адрес");
            DGridView1.Columns[6].Width = 500;
            DGridView1.Columns[6].ReadOnly = true;

            DGridView1.Columns.Add("Тип", "Тип");
            DGridView1.Columns[7].Width = 150;
            DGridView1.Columns[7].ReadOnly = true;

            // Маркера для окраски строк
            DicColor.Add(EpNotificationStruct.PlacingWayEnum.ЗапросКотировок, System.Drawing.Color.SeaGreen);
            DicColor.Add(EpNotificationStruct.PlacingWayEnum.ЗакупкаEдинственного, System.Drawing.Color.LightYellow);
            DicColor.Add(EpNotificationStruct.PlacingWayEnum.Ответ_запрос, System.Drawing.Color.LightSkyBlue);
            DicColor.Add(EpNotificationStruct.PlacingWayEnum.Отмена, System.Drawing.Color.IndianRed);
        }
        private void SaveXml(string sFile)
        {
            if (File.Exists(sFile)) File.Delete(sFile);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EpNotificationStruct>));
            using (FileStream fs = new FileStream(sFile, FileMode.Create)) xmlSerializer.Serialize(fs, AllepNotifications);
        }
        private void LogError(string v)
        {
            MessageBox.Show(v, "Ошибка");

            // Чистим каталог с получеными файлами
            DirectoryInfo d = new DirectoryInfo(DirTmp);
            foreach (DirectoryInfo dir in d.GetDirectories()) dir.Delete(true);
        }
        private void Refreh_AllepNotifications()
        {
            DGridView1.Rows.Clear();
            int i = 0;
            foreach (var item in AllepNotifications)
            {
                i++;
                DGridView1.Rows.Add(item.ToArray());
                if (DicColor.ContainsKey(item.PlacingWay)) { DGridView1.Rows[DGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = DicColor[item.PlacingWay]; }
                else { DGridView1.Rows[DGridView1.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.White; }
            }
            SumItog.Text = "Всего в списке строк: " + i;
        }
        private void Save1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AllepNotifications == null) { MessageBox.Show("Сначало следует загрузить данные"); return; }

            saveFileDialog1.FileName = "report.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
            string sfile = saveFileDialog1.FileName;

            SpreadsheetDocument document = SpreadsheetDocument.Create(sfile, SpreadsheetDocumentType.Workbook);
            WorkbookPart workbookPart = document.AddWorkbookPart();
            workbookPart.Workbook = new Workbook();
            WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet();
            Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
            Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Отчет" };
            sheets.Append(sheet);

            SheetData sheetData = worksheetPart.Worksheet.AppendChild(new SheetData());

            Row headerRow = new Row();
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("ID") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("№ извещения") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("Дата") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("ЭТП") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("Название") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("Н/Цена") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("Адрес") });
            headerRow.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue("Ссылка") });

            sheetData.AppendChild(headerRow);

            foreach (var item in AllepNotifications)
            {
                Row row = new Row();
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.id.ToString()) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.purchaseNumber.ToString()) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.publishDTInEIS.ToString()) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.ETP_name) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.purchaseObjectInfo) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.maxPrice) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.postAddress) });
                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(item.href) });
                sheetData.AppendChild(row);
            }

            worksheetPart.Worksheet.Save();
            document.Dispose();
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\lastResult.xml") == false)
            {
                MessageBox.Show("Загрузка не производилась.");
                return;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EpNotificationStruct>));
            using (FileStream fs = new FileStream(Application.StartupPath + @"\lastResult.xml", FileMode.Open))
            {
                AllepNotifications = xmlSerializer.Deserialize(fs) as List<EpNotificationStruct>;
            }
            Refreh_AllepNotifications();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (DGridView1.SelectedCells.Count > 0)
            {
                string id = DGridView1.Rows[DGridView1.SelectedCells[0].RowIndex].Cells["id"].Value.ToString();
                Process.Start(AllepNotifications.Find(x => x.id.ToString() == id).href);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SelectDay days = new SelectDay(ref DaySelect);
            days.Show();
        }
        private void CBox1_CheckedChanged(object sender, EventArgs e)
        {
            Button2.Enabled = !CBox1.Checked;
        }

        async private void Button1_Click(object sender, EventArgs e)
        {
            PBox1.Image = null;
            PBox2.Image = null;
            PBox3.Image = null;
            PBox4.Image = null;

            //Проверка соеденения
            PBox1.Image = Properties.Resources.loading;
            bool pingEcho = await Task.Run(() =>
            {
                Task.Delay(1000);
                Ping ping = new Ping();
                try
                {
                    var reply = ping.Send("zakupki.gov.ru", 1500, new byte[32], new PingOptions());
                    return reply.Status == IPStatus.Success;
                }
                catch
                {
                    return false;
                }
            });

            if (pingEcho)
            {
                PBox1.Image = Properties.Resources.Tick_Mark_icon_icons_com_69146;
            }
            else
            {
                PBox1.Image = Properties.Resources.vcsconflicting_93497;
                return;
            }

            // получаем список файлов для загрузки
            PBox2.Image = Properties.Resources.loading;
            List<Xml_zipStruct> xml_Zips = new List<Xml_zipStruct>();

            FtpWebRequest ftp = WebRequest.Create(TargetFtp) as FtpWebRequest;
            ftp.Method = WebRequestMethods.Ftp.ListDirectory;
            ftp.Credentials = new NetworkCredential("free", "free");

            await Task.Run(() =>
             {
                 using (StreamReader streamReader = new StreamReader(ftp.GetResponse().GetResponseStream()))
                 {
                     string str = streamReader.ReadLine();
                     while (!string.IsNullOrEmpty(str))
                     {
                         xml_Zips.Add(new Xml_zipStruct(str));
                         str = streamReader.ReadLine();
                     }
                 }
             });

            if (xml_Zips.Count != 0)
            {
                PBox2.Image = Properties.Resources.Tick_Mark_icon_icons_com_69146;
            }
            else
            {
                PBox2.Image = Properties.Resources.vcsconflicting_93497;
                return;
            }

            // Тут сортировка нужных файлов
            PBox3.Image = Properties.Resources.loading;
            string[] Order;
            if (CBox1.Checked)         // Последняя выгрузка
            {
                DateTime date = xml_Zips.LastOrDefault().nowDate;
                Order = (from TV in xml_Zips where TV.nowDate == date select TargetFtp + TV.fileName).ToArray();
            }
            else
            {                     // Выборка 
                Order = (from TV in xml_Zips where DaySelect.Contains(TV.nowDate.Day) == true select TargetFtp + TV.fileName).ToArray();
            }
            if (Order.Length == 0)
            {
                PBox3.Image = Properties.Resources.vcsconflicting_93497;
                return;
            }

            //скачиваем файлы
            LabelIndex.Text = "0/" + Order.Length;
            IProgress<int> progress = new Progress<int>(value => { LabelIndex.Text = (value + 1) + "/" + Order.Length; });

            await Task.Run(() =>
            {
                for (int i = 0; i < Order.Length; i++)
                {
                    using (var client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential("free", "free");
                        client.DownloadFile(Order[i], DirTmp + i + ".zip");
                    }
                    progress.Report(i);
                }
            });
            PBox3.Image = Properties.Resources.Tick_Mark_icon_icons_com_69146;

            //Распаковка фалов
            PBox4.Image = Properties.Resources.loading;
            List<string> patchFileXml = new List<string>();  // Какие файлы назначить для чтения из каталога
            List<string> rm = new List<string>();            // на удаление каталоги

            foreach (var item in Directory.GetFiles(DirTmp))
            {
                string sFile = item.Substring(0, item.Length - 4) + @"\";
                if (Directory.Exists(sFile) == false) Directory.CreateDirectory(sFile); rm.Add(sFile);
                try { ZipFile.ExtractToDirectory(item, sFile); }
                catch (Exception ex)
                {
                    LogError("Ошибка: " + ex.Message);
                    PBox4.Image = Properties.Resources.vcsconflicting_93497;
                    return;
                }
                File.Delete(item);    // Сразу удаляем архив

                foreach (var file in Directory.GetFiles(sFile))
                {
                    if (file.Substring(file.Length - 4) == ".xml") patchFileXml.Add(file);
                }
            }
            PBox4.Image = Properties.Resources.Tick_Mark_icon_icons_com_69146;

            // Обрабатываем файлы
            ProgFile1.Visible = true;
            ProgFile1.Minimum = 0;
            ProgFile1.Maximum = patchFileXml.Count;
            IProgress<int> ProgFile = new Progress<int>(value => ProgFile1.Value = value);

            List<EpNotificationStruct> epsAll = await Task.Run(() =>
            {
                List<EpNotificationStruct> eps = new List<EpNotificationStruct>();
                for (int i = 0; i < patchFileXml.Count; i++)
                {
                    ProgFile.Report(i);
                    eps.Add(new EpNotificationStruct(XDocument.Load(patchFileXml[i])));
                    File.Delete(patchFileXml[i]);    // Сразу удаляем файл
                }
                return eps;
            });

            foreach (var dir in rm)
            {
                foreach (FileInfo file in new DirectoryInfo(dir).GetFiles()) file.Delete();
                Directory.Delete(dir);
            }
            AllepNotifications = epsAll;
            ProgFile1.Visible = false;
            Refreh_AllepNotifications();
            SaveXml(Application.StartupPath + @"\lastResult.xml");
        }

        //-----------------------------------------------------------------------------------------
        private struct Xml_zipStruct
        {
            public DateTime firstDate;
            public DateTime nowDate;
            public int Num;
            public string fileName;

            public Xml_zipStruct(string title)
            {
                fileName = title;
                title = title.Substring(title.Length - 33);
                string[] s_title = title.Split('_');

                firstDate = DateTime.Parse(s_title[0].Substring(0, 4) + "-" + s_title[0].Substring(4, 2) + "-" + s_title[0].Substring(6, 2));
                nowDate = DateTime.Parse(s_title[1].Substring(0, 4) + "-" + s_title[1].Substring(4, 2) + "-" + s_title[1].Substring(6, 2));
                Num = int.Parse(s_title[2].Substring(0, 3));
            }

            public override string ToString() => $"{firstDate.Date} > {nowDate.Date} № {Num}";
        }
    }
}
