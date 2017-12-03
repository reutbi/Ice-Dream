using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net.Mail;
using System.Net;
using System.Drawing.Printing;

namespace IceDream
{  
    public partial class incomeOutcome : Form
    {
        //************************************************************************************************************
        public static string pathIncomes = Path.Combine(Environment.CurrentDirectory, "Incomes.txt");
        public static string pathOutcomes = Path.Combine(Environment.CurrentDirectory, "Outcomes.txt");
        public static Thread thOpenMM;
        DataTable incomesTable = new DataTable();
        DataTable outcomesTable = new DataTable();
        public static string readIncomes = File.ReadAllText(pathIncomes).ToString();
        public static string readOutcomes = File.ReadAllText(pathOutcomes).ToString();
        public static int sumIn = 0;                            //יקבל את סכום ההכנסות העדכני
        public static int sumOut = 0;                           //יקבל את סכום ההוצאות העדכני
        public static int CurrentBalance = 0;                   //יקבל את סכום המאזן העדכני
        public static string savedMail;                         //לשמירת כתובת המייל
        private DateTime clock = DateTime.Now;                  //להצגת שעון במסך
        //*************************************************************************************************************
        public incomeOutcome()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        public void LoadIncomes()                                                         //שיטה לטעינת קובץ ההכנסות
        {
            string[] incomeData = File.ReadAllLines("Incomes.txt");
            //******************הכנסת נתוני ההכנסות מהקובץ לטבלה**********
            if (incomeData.Length > 0)              
            {
                string[] headers = incomeData[0].Split('-');

                foreach (string header in headers)                 //הוספת עמודות
                    incomesTable.Columns.Add(header, typeof(string), null);

                for (int i = 0; i < incomeData.Length; i++)         //הוספת נתוני השורות
                        incomesTable.Rows.Add(incomeData[i].Split('-'));
                        dgvIncomes.DataSource = incomesTable;       
            }
            //***************************************************************
        }
        public void LoadOutcomes()                                                        //טעינת קובץ ההוצאות
        {
            string[] outcomeData = File.ReadAllLines("Outcomes.txt");
            //**************הכנסת נתוני ההוצאות מהקובץ לטבלה**************
            if (outcomeData.Length > 0)
            {
                string[] header = outcomeData[0].Split('-');

                foreach (string head in header)
                    outcomesTable.Columns.Add(head, typeof(string), null);  //הוספת העמודות
                for (int i = 0; i < outcomeData.Length; i++)
                    outcomesTable.Rows.Add(outcomeData[i].Split('-'));      //הוספת נתוני השורות
                dgvOutcomes.DataSource = outcomesTable;
            }
            //***************************************************************
        }
        private void incomeOutcome_Load(object sender, EventArgs e)                       //טעינת נתונים בפתיחת המסך
        {
            LoadIncomes();
            LoadOutcomes();
            sumInOut();
            lblSumIn.Text = sumIn.ToString();                        //הצגת סכום ההכנסות העדכני
            lblSumOut.Text = sumOut.ToString();                     //הצגת סכום ההוצאות העדכני
            lblCurrentBalance.Text = CurrentBalance.ToString();     //הצגת סך המאזן העדכני
            if (savedMail!= null)
                emailTxeBox.Text = savedMail.ToString();

        }
        private void back_btn_Click(object sender, EventArgs e)                           //כפתור חזרה
        {
            sumIn = 0;                  //  \
            sumOut = 0;                 //   |>   איפוס הסכומים הסופיים המוצגים
            CurrentBalance = 0;        //   /
            this.Close();
            thOpenMM = new Thread(MainMenuForm);
            thOpenMM.SetApartmentState(ApartmentState.STA);
            thOpenMM.Start();
        }
        private void btnResetData_Click(object sender, EventArgs e)                       //איפוס הנתונים בקובץ הכנסות והוצאות
        {
            DialogResult dlgresult = MessageBox.Show("האם אתה בטוח? אם תלחץ על אישור, יימחקו כל הנתונים המוצגים", "הודעת אזהרה",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlgresult == DialogResult.OK)
            {
                StreamWriter defaultIncomes = new StreamWriter(pathIncomes);
                StreamWriter defaultOutcomes = new StreamWriter(pathOutcomes);
                defaultIncomes.Close();
                defaultOutcomes.Close();
                dgvIncomes.DataSource = null; // מחיקת נתונים שמוצגים מהקובץ לפני האיפוס
                dgvOutcomes.DataSource = null;
                sumIn = 0;
                sumOut = 0;
                lblSumIn.Text = "0";
                lblSumOut.Text = "0";
                lblCurrentBalance.Text = "0";
            }
        }
        private void sumInOut()                                                           //שיטה לסיכום ההכנסות וההוצאות
        {
            if (incomesTable.Rows != null)
            {
                foreach (DataRow row in incomesTable.Rows)
                {
                    object[] arrayIn = row.ItemArray;

                    for (int i = 0; i < arrayIn.Length - 1; i++)
                    {
                            sumIn += Int32.Parse(arrayIn[i].ToString());            //חישוב סך ההכנסות
                    }
                }
            }
           if (outcomesTable.Rows != null)
            {
                foreach (DataRow row in outcomesTable.Rows)
                {
                    object[] arrayOut = row.ItemArray;

                    for (int j = 0; j < arrayOut.Length - 1; j++)
                    {
                       sumOut += Int32.Parse(arrayOut[j].ToString());           //חישוב סך ההוצאות
                    }
                }
            }
            CurrentBalance = sumIn - sumOut;                                    //חישוב סך המאזן
        }
        private void send_mail_Click(object sender, EventArgs e)                          //שליחת הדו"ח למייל
        {
            if (lblCurrentBalance.Text != "0" || lblSumIn.Text != "0" || lblSumOut.Text != "0")
            {

                if (emailTxeBox.Text == "")                                         //בדיקה אם הוזנה כתובת מייל לשליחה
                {
                    MessageBox.Show("אנא הזן כתובת מייל לשליחה");
                }
                else
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);      //שרת ג'ימייל
                        mail.From = new MailAddress("IceDreamMail@gmail.com");              //הכתובת שממנה נשלח המייל
                        mail.To.Add(emailTxeBox.Text);                                      //הכתובת אליה נשלח המייל
                        savedMail = emailTxeBox.Text;                                       //שמירת כתובת המייל בתיבת הטקסט
                        mail.Subject = "New Report from IceDream";                          //נושא ההודעה במייל
                        mail.Body = "להלן סיכום המאזן העדכני: \n" + "סך ההכנסות: " + sumIn + "\n" + "סך ההוצאות: " + sumOut + "\n" + "סך המאזן: " + CurrentBalance + "\n" + "מצ\"ב קבצים עם פירוט ההכנסות וההוצאות";
                        Attachment attachmentIn = new Attachment("Incomes.txt");            //הוספת קובץ ההכנסות למייל
                        Attachment attachmentOut = new Attachment("Outcomes.txt");          //הוספת קובץ ההוצאות למייל
                        mail.Attachments.Add(attachmentIn);
                        mail.Attachments.Add(attachmentOut);
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new NetworkCredential("IceDreamMail", "IceDreamMail123");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);                                              //שליחת המייל
                        MessageBox.Show("המייל נשלח בהצלחה", "Email Message");
                    }
                    catch (Exception ex)                //זריקת חריג
                    {
                        DialogResult dlgresult = MessageBox.Show(":שליחת המייל נכשלה, ייתכן ש\r \n" + "החיבור לאינטרנט אינו תקין\r - \n" + "או שכתובת המייל שהזנת אינה תקינה\r",
                            "הודעת אזהרה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            else
                MessageBox.Show("לא ניתן לשלוח כאשר הנתונים מאופסים");
        }
        private void btnPrint_Click(object sender, EventArgs e)                           //לחיצה על כפתור הדפסה
        {
            if (lblCurrentBalance.Text != "0" || lblSumIn.Text != "0" || lblSumOut.Text != "0")
                print();
            else
                MessageBox.Show("לא ניתן להדפיס כאשר הנתונים מאופסים");
        }
        private void print()                                                              //שיטה להדפסת הדו"ח
        {
            printDialog_Report.Document = printDoc_Report;

            if (printDialog_Report.ShowDialog() == DialogResult.OK)
            {
                printDoc_Report.Print();
            }
        }
        private void printDoc_Report_PrintPage(object sender, PrintPageEventArgs e)       //תוכן הקובץ שנשלח להדפסה
        {
            Image icedreamlogo = Image.FromFile("icedreamlogo.jpg");    // Create image.
            PointF ulCorner = new PointF(50.0F, 5.0F);                 // Create point for upper-left corner of image.
            e.Graphics.DrawImage(icedreamlogo, ulCorner);               // Draw logo on the file
            e.Graphics.DrawString("\r" + CurrentBalance + "₪" + "\r" + "\t" + ":סיכום המאזן    ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Blue, 600, 30); //draw data to the file
            e.Graphics.DrawString("**************************************************************", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Blue, 100, 100);
            e.Graphics.DrawString("סך כל ההכנסות:    " + sumIn + "\n", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Green, 100, 80); //draw data to the file
            e.Graphics.DrawString(readIncomes, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 100, 120); //draw data to the file
            e.Graphics.DrawString(" סך כל ההוצאות:    " + sumOut + "\n", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Red, 400, 80); //draw data to the file
            e.Graphics.DrawString(readOutcomes, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, 400, 120); //draw data to the file
        }
        private void MainMenuForm()
        {
            Application.Run(new MainMenuForm());
        }
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }                       //טיימר להצגת שעון רץ
    }
}
