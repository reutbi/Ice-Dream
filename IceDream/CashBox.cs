using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;
using System.Drawing.Printing;

namespace IceDream
{

    public partial class FormCashBox : Form
    {
        //*************************************************************************************
        public const int NUM_OF_PRODUCTS = 20;                                                  //מספר המוצרים בגלידרייה
        XmlDocument xDoc = new XmlDocument();
        public string pathIncomes = Path.Combine(Environment.CurrentDirectory, "Incomes.txt");  //נתיב קובץ ההכנסות
        public static Thread thOpenMM;
        public DateTime dt = new DateTime();                                                    //להוספת תאריך ביצוע רכישה
        int[] sum = new int[NUM_OF_PRODUCTS];                                                   //הסכום הסופי של כל מוצר
        string[] amount = new string[NUM_OF_PRODUCTS];                                          //כמות כל מוצר
        string[] name = new string[NUM_OF_PRODUCTS];                                            //שמו של כל מוצר
        string strPrint = "";                                                                   //מחרוזת להדפסה בחשבונית
        bool CheckIfChange = false;                                                             //דגל לבדיקת שינויים
        private DateTime clock = DateTime.Now;                                                  //להצגת שעון במסך
        //**************************************************************************************
        public FormCashBox()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        public void plus(Label a)                 //כפתור +
        {
            int i = Int32.Parse(a.Text);
              i++;
              a.Text = i.ToString();
            summaryCashBox();
          }
        public void minus(Label a)              //כפתור -
        {
              int i = Int32.Parse(a.Text);
             i--;
             if (i >= 0)
                 a.Text = i.ToString();
             else
            {
               MessageBox.Show("שים לב, לא ניתן להכניס ערך שלילי", "הודעת אזהרה",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            summaryCashBox();
        }
        public void summaryCashBox()                                                           //שיטה שמחשבת את הסכום הכולל לתשלום בקופה
        {
            int summary = 0;            //Variable(summary) to calculate the total amount
            xDoc.Load(IceDream.MainMenuForm.path + "\\DatabasePrice.xml");
            #region amount[]
            amount[0] = lblAmount_IceCream.Text;
            amount[1] = lblAmount_Cups.Text;
            amount[2] = lblAmount_Crepe.Text;
            amount[3] = lblAmount_BelgianWaffles.Text;
            amount[4] = lblAmount_Pancake.Text;
            amount[5] = lblAmount_Fluff.Text;
            amount[6] = lblAmount_Chocolate.Text;
            amount[7] = lblAmount_Candies.Text;
            amount[8] = lblAmount_Fruits.Text;
            amount[9] = lblAmount_Nuts.Text;
            amount[10] = lblAmount_Espresso.Text;
            amount[11] = lblAmount_Cappuccino.Text;
            amount[12] = lblAmount_InstantCoffee.Text;
            amount[13] = lblAmount_Tea.Text;
            amount[14] = lblAmount_ChocolateMilk.Text;
            amount[15] = lblAmount_CocaCola.Text;
            amount[16] = lblAmount_Sprite.Text;
            amount[17] = lblAmount_Orange.Text;
            amount[18] = lblAmount_Nestea.Text;
            amount[19] = lblAmount_Water.Text; 
            #endregion
            #region name[]
            name[0] = lblIceCream.Text;
            name[1] = lblCup.Text;
            name[2] = lblCrepe.Text;
            name[3] = lblBelgianWaffles.Text;
            name[4] = lblPancake.Text;
            name[5] = lblFluff.Text;
            name[6] = lblChocolate.Text;
            name[7] = lblCandies.Text;
            name[8] = lblFruits.Text;
            name[9] = lblNuts.Text;
            name[10] = lblEspresso.Text;
            name[11] = lblCappuccino.Text;
            name[12] = lblInstantCoffee.Text;
            name[13] = lblTea.Text;
            name[14] = lblChocolateMilk.Text;
            name[15] = lblCocaCola.Text;
            name[16] = lblSprite.Text;
            name[17] = lblOrange.Text;
            name[18] = lblNestea.Text;
            name[19] = lblWater.Text; 
            #endregion
            #region sum[]
            sum[0] = Int32.Parse(amount[0]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/IceCream/Price").InnerText));
            sum[1] = Int32.Parse(amount[1]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Cups/Price").InnerText));
            sum[2] = Int32.Parse(amount[2]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Crepe/Price").InnerText));
            sum[3] = Int32.Parse(amount[3]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/BelgianWaffles/Price").InnerText));
            sum[4] = Int32.Parse(amount[4]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Pancake/Price").InnerText));
            sum[5] = Int32.Parse(amount[5]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Fluff/Price").InnerText));
            sum[6] = Int32.Parse(amount[6]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Chocolate/Price").InnerText));
            sum[7] = Int32.Parse(amount[7]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Candies/Price").InnerText));
            sum[8] = Int32.Parse(amount[8]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Fruits/Price").InnerText));
            sum[9] = Int32.Parse(amount[9]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Nuts/Price").InnerText));
            sum[10] = Int32.Parse(amount[10]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Espresso/Price").InnerText));
            sum[11] = Int32.Parse(amount[11]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Cappuccino/Price").InnerText));
            sum[12] = Int32.Parse(amount[12]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/InstantCoffee/Price").InnerText));
            sum[13] = Int32.Parse(amount[13]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Tea/Price").InnerText));
            sum[14] = Int32.Parse(amount[14]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/ChocolateMilk/Price").InnerText));
            sum[15] = Int32.Parse(amount[15]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/CocaCola/Price").InnerText));
            sum[16] = Int32.Parse(amount[16]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Sprite/Price").InnerText));
            sum[17] = Int32.Parse(amount[17]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Orange/Price").InnerText));
            sum[18] = Int32.Parse(amount[18]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Nestea/Price").InnerText));
            sum[19] = Int32.Parse(amount[19]) * Int32.Parse((xDoc.SelectSingleNode("allProducts/Water/Price").InnerText));
            #endregion
            strPrint = "******************************\n" + "שם                    כמות               מחיר\n" + "******************************\n";
            for (int i = 0; i < NUM_OF_PRODUCTS; i++)
            {
                    summary += sum[i];                                       //כל שינוי בסכום כל מוצר מתעדכן בסכום הכולל
                    if (Int32.Parse(amount[i]) > 0)     
                    {
                         CheckIfChange = true;                              //התבצע שינוי בלפחות אחד מהמוצרים
                         strPrint += "\n    " + name[i] + "               " + amount[i] + "                    " + sum[i] + "\n";
                    }
                        if (summary >= 0)
                    {
                        tbTotalPayment.Text = summary.ToString();            //the total amount will be dislpay 
                    }
            }          
            strPrint += "******************************\n" + "               סה\"כ לתשלום:"+ "     ₪"+ tbTotalPayment.Text ;
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            if (CheckIfChange)          //בדיקה אם בוצעו שינויים
            {
                DialogResult dlgresult = MessageBox.Show("?האם אתה בטוח שברצונך לצאת ", "הודעת אזהרה",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dlgresult == DialogResult.OK)
                {
                    this.Close();
                    thOpenMM = new Thread(MainMenuForm);
                    thOpenMM.SetApartmentState(ApartmentState.STA);
                    thOpenMM.Start();
                }
            }
            else
            {
                this.Close();
                thOpenMM = new Thread(MainMenuForm);
                thOpenMM.SetApartmentState(ApartmentState.STA);
                thOpenMM.Start();
            }
        }                            //כפתור חזרה
        #region PlusMinusButtons                                                                      //כפתורי פלוס ומינוס
        private void btnPlus_IceCream_Click(object sender, EventArgs e)
        {
            plus(lblAmount_IceCream);
        }

        private void btnMinus_IceCream_Click(object sender, EventArgs e)
        {
            minus(lblAmount_IceCream);
        }

        private void btnPlus_Cup_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Cups);
        }

        private void btnMinus_Cup_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Cups);
        }

        private void btnPlus_Crepe_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Crepe);
        }

        private void btnMinus_Crepe_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Crepe);
        }

        private void btnPlus_BelgianWaffles_Click(object sender, EventArgs e)
        {
            plus(lblAmount_BelgianWaffles);
        }

        private void btnMinus_BelgianWaffles_Click(object sender, EventArgs e)
        {
            minus(lblAmount_BelgianWaffles);
        }

        private void btnPlus_Pancake_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Pancake);
        }

        private void btMinus_Pancake_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Pancake);
        }

        private void btnPlus_Fluff_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Fluff);
        }

        private void btMinus_Fluff_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Fluff);
        }

        private void btnPlus_Chocolate_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Chocolate);
        }

        private void btnMinus_Chocolate_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Chocolate);
        }

        private void btnPlus_Candies_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Candies);
        }

        private void btnMinus_Candies_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Candies);
        }

        private void btnPlus_Fruits_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Fruits);
        }

        private void btnMinus_Fruits_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Fruits);
        }

        private void btnPlus_Nuts_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Nuts);
        }

        private void btnMinus_Nuts_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Nuts);
        }

        private void btnPlus_Espresso_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Espresso);
        }

        private void btnMinus_Espresso_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Espresso);
        }

        private void btnPlus_Cappuccino_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Cappuccino);

        }

        private void btnMinus_Cappuccino_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Cappuccino);

        }

        private void btnPlus_InstantCoffee_Click(object sender, EventArgs e)
        {
            plus(lblAmount_InstantCoffee);

        }

        private void btnMinus_InstantCoffee_Click(object sender, EventArgs e)
        {
            minus(lblAmount_InstantCoffee);

        }

        private void btnPlus_Tea_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Tea);
        }

        private void btnMinus_Tea_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Tea);
        }

        private void btnPlus_ChocolateMilk_Click(object sender, EventArgs e)
        {
            plus(lblAmount_ChocolateMilk);
        }

        private void btnMinus_ChocolateMilk_Click(object sender, EventArgs e)
        {
            minus(lblAmount_ChocolateMilk);
        }

        private void btnPlus_CokaCola_Click(object sender, EventArgs e)
        {
            plus(lblAmount_CocaCola);
        }

        private void btnMinus_CokaCola_Click(object sender, EventArgs e)
        {
            minus(lblAmount_CocaCola);
        }

        private void btnPlus_Sprite_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Sprite);
        }

        private void btnMinus_Sprite_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Sprite);
        }

        private void btnPlus_Orange_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Orange);
        }

        private void btnMinus_Orange_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Orange);
        }

        private void btnPlus_Nestea_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Nestea);
        }

        private void btnMinus_Nestea_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Nestea);
        }

        private void btnPlus_Water_Click(object sender, EventArgs e)
        {
            plus(lblAmount_Water);
        }

        private void btnMinus_Water_Click(object sender, EventArgs e)
        {
            minus(lblAmount_Water);
        }
        #endregion
        private void btnEnter_Print_Click(object sender, EventArgs e)                         //כפתור שמירה והדפסת חשבונית
        {
            //*******************שמירת החשבון האחרון שבוצע בקובץ***************************************************
            FileStream fileIncomes = new FileStream(pathIncomes, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            StreamReader SR = new StreamReader(fileIncomes);
            string str = "";

            dt = DateTime.Now;
            if (tbTotalPayment.Text != "0")
            {
                str = tbTotalPayment.Text + " - " + dt;
            }
            SR.Close();
            StreamWriter SW = new StreamWriter(pathIncomes,true);
            if (tbTotalPayment.Text != "0")
            {
                SW.WriteLine(str);
            }
            else
            {
                SW.Write("");
            }
            SW.Close();
            //********************************************************************************************************
            print();
            reset();
        }
        private void print()                                                                  //שיטה להדפסת החשבונית
        {
            if (tbTotalPayment.Text != "0")
            {
                printDialog_Bill.Document = printDocument_Bill;

                if (printDialog_Bill.ShowDialog() == DialogResult.OK)
                {
                    printDocument_Bill.Print();
                }
            }
            else
            {
                DialogResult dlgresult = MessageBox.Show("שים לב, כאשר החשבון ריק, אין חשבונית להדפסה- תחילה יש לבחור את הפריטים שנמכרו ", "הודעה לקופאי",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        }
        private void printDocument_Bill_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create image.
            Image icedreamlogo = Image.FromFile("icedreamlogo.jpg");

            // Create point for upper-left corner of image.
            PointF ulCorner = new PointF(100.0F, 50.0F);

            // Draw image to screen.
            e.Graphics.DrawImage(icedreamlogo, ulCorner);       //הוספת הלוגו לחשבונית
            string strspace = Environment.NewLine+""+ Environment.NewLine+ Environment.NewLine+ Environment.NewLine;
            e.Graphics.DrawString(strspace, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 100, 125);
            e.Graphics.DrawString(strPrint, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 100, 125);
        }     //תוכן הקובץ שנשלח להדפסה
        private void reset()                                                                  //שיטה לאיפוס הנתונים
        {
            lblAmount_IceCream.Text = "0";
            lblAmount_Cups.Text = "0";
            lblAmount_Crepe.Text = "0";
            lblAmount_BelgianWaffles.Text = "0";
            lblAmount_Pancake.Text = "0";
            lblAmount_Fluff.Text = "0";
            lblAmount_Chocolate.Text = "0";
            lblAmount_Candies.Text = "0";
            lblAmount_Fruits.Text = "0";
            lblAmount_Nuts.Text = "0";
            lblAmount_Espresso.Text = "0";
            lblAmount_Cappuccino.Text = "0";
            lblAmount_InstantCoffee.Text = "0";
            lblAmount_Tea.Text = "0";
            lblAmount_ChocolateMilk.Text = "0";
            lblAmount_CocaCola.Text = "0";
            lblAmount_Sprite.Text = "0";
            lblAmount_Orange.Text = "0";
            lblAmount_Nestea.Text = "0";
            lblAmount_Water.Text = "0";
            tbTotalPayment.Text = "0";
        }
        private void MainMenuForm()
        {
            Application.Run(new MainMenuForm());
        }
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }                           //טיימר להצגת שעון רץ
    }
}

