using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Drawing;

namespace IceDream
{
    public partial class MainMenuForm : Form
    {
        private DateTime clock = DateTime.Now;                              //להצגת שעון על המסך
        public static bool saveClicked;                                     //to ensure the save button clicked.
        public static bool Changed;                                         //to ensure the text box value changed.

        public MainMenuForm()
        {
            InitializeComponent();
            lblClock.Text = clock.ToString();
        }
        //**********************************************************
        public static string path = Directory.GetCurrentDirectory();
        public static Thread thOpenNewForm;
        FileStream fsIncome;
        FileStream fsOutcome;
        //**********************************************************
        private void button3_Click(object sender, EventArgs e)                 //מעבר למסך קופה
        {
            this.Close();
            thOpenNewForm = new Thread(FormCashBox);
            thOpenNewForm.SetApartmentState(ApartmentState.STA);
            thOpenNewForm.Start();
        }
        private void FormCashBox()
        {
            Application.Run(new FormCashBox());

        }
        private void invManagment_btn_Click(object sender, EventArgs e)        //מעבר למסך ניהול מלאי
        {
            this.Close();
            thOpenNewForm = new Thread(thOpenInvM_Form);
            thOpenNewForm.SetApartmentState(ApartmentState.STA);
            thOpenNewForm.Start();
        }
        private void thOpenInvM_Form()
        {
            Application.Run(new invManagment());
        }
        private void incomeOutcome_btn_Click(object sender, EventArgs e)       //מעבר למסך הכנסאות/הוצאות
        {
            this.Close();
            thOpenNewForm = new Thread(incomeOutcome);
            thOpenNewForm.SetApartmentState(ApartmentState.STA);
            thOpenNewForm.Start();
        }
        private void incomeOutcome()
        {
            Application.Run(new incomeOutcome());
        }
        private void cashBoxSetting_btn_Click(object sender, EventArgs e)      //מעבר למסך הגדרות קופה
        {
            this.Close();
            thOpenNewForm = new Thread(CashBoxSetting);
            thOpenNewForm.SetApartmentState(ApartmentState.STA);
            thOpenNewForm.Start();
        }
        private void CashBoxSetting()
        {
            Application.Run(new CashBoxSetting());
        }
        private void costSetting_btn_Click(object sender, EventArgs e)        //מעבר למסך הגדרות מחירי מלאי
        {
            this.Close();
            thOpenNewForm = new Thread(costSetting_form);
            thOpenNewForm.SetApartmentState(ApartmentState.STA);
            thOpenNewForm.Start();
        }
        private void costSetting_form()
        {
            Application.Run(new costSetting());
        }
        private void exit_btn_Click(object sender, EventArgs e)               //כפתור יציאה מהתוכנה

        {
            DialogResult dlgresult = MessageBox.Show("האם אתה בטוח שברצונך לצאת?", "הודעת אזהרה",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlgresult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void xmlmake()                                                 //יצירת קבצי אקס-אמל לשמירת נתוני ההגדרות במידה ואינם קיימים
        {
            if (File.Exists(path + "\\DatabaseInvManagment.xml") == false)
            {
                XmlTextWriter xWriter = new XmlTextWriter(path + "\\DatabaseInvManagment.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement("allProducts");
                xWriter.WriteStartElement("iceCream");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Cups");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Cones");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Napkins");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Spreads");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sauces");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Crepes");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Pancakes");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Teaspoons");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("CocaCola");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sprite");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Oranges");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Nestea");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Waters");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Nutellas");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Candies");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("BelgianWaffles");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("CoffeeBeans");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("InstantCoffees");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Sugars");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Mousses");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("WhiteChocolates");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Strawberries");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Bananas");
                xWriter.WriteStartElement("numberOfProducts");
                xWriter.WriteString("0");
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.Close();
            }

            if (System.IO.File.Exists(path + "\\DatabasePrice.xml") == false)
            {
                XmlTextWriter xWriterPrice = new XmlTextWriter(path + "\\DatabasePrice.xml", Encoding.UTF8);
                xWriterPrice.Formatting = Formatting.Indented;
                xWriterPrice.WriteStartElement("allProducts");
                xWriterPrice.WriteStartElement("IceCream");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Cups");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Crepe");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("BelgianWaffles");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Pancake");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Fluff");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Chocolate");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Candies");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Fruits");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Nuts");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Espresso");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Cappuccino");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("InstantCoffee");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Tea");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("ChocolateMilk");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("CocaCola");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Sprite");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Orange");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Nestea");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteStartElement("Water");
                xWriterPrice.WriteStartElement("Price");
                xWriterPrice.WriteString("0");
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();
                xWriterPrice.WriteEndElement();

                xWriterPrice.Close();
            }
            if (System.IO.File.Exists(path + "\\DatabaseCost.xml") == false)
            {
                XmlTextWriter xWriterCost = new XmlTextWriter(path + "\\DatabaseCost.xml", Encoding.UTF8);
                xWriterCost.Formatting = Formatting.Indented;
                xWriterCost.Formatting = Formatting.Indented;
                xWriterCost.WriteStartElement("allProducts");
                xWriterCost.WriteStartElement("iceCream");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Cups");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Cones");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Napkins");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Spreads");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Sauces");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Crepes");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Pancakes");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Teaspoons");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("CocaCola");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Sprite");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Oranges");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Nestea");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Waters");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Nutellas");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Candies");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("BelgianWaffles");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("CoffeeBeans");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("InstantCoffees");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Sugars");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Mousses");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("WhiteChocolates");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Strawberries");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.WriteEndElement();
                xWriterCost.WriteStartElement("Bananas");
                xWriterCost.WriteStartElement("Cost");
                xWriterCost.WriteString("0");
                xWriterCost.WriteEndElement();
                xWriterCost.Close();
            }
        }
        void makeTXT()                                                         //יצירת קבצי טקסט להכנסות והוצאות במידה ואינם קיימים
        {
            if (File.Exists(IceDream.incomeOutcome.pathIncomes) == false)
            {
                fsIncome = new FileStream(IceDream.incomeOutcome.pathIncomes, FileMode.Create);
                fsIncome.Close();
            }
            if (File.Exists(IceDream.incomeOutcome.pathOutcomes) == false)
            {
                fsOutcome = new FileStream(IceDream.incomeOutcome.pathOutcomes, FileMode.Create);
                fsOutcome.Close();
            }
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        
            xmlmake();
            makeTXT();

        }         //טעינת המסך הראשי   
        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            clock = DateTime.Now;
            lblClock.Text = clock.ToString();
        }          //טיימר להפעלת שעון שיוצג על המסך
        #region Buttons_Mouse_Hover_&_Leave
        private void incomeOutcome_btn_MouseHover(object sender, EventArgs e)
        {
            incomeOutcome_btn.ForeColor = Color.Yellow;
        }
        private void incomeOutcome_btn_MouseLeave(object sender, EventArgs e)
        {
            incomeOutcome_btn.ForeColor = Color.White;
        }
        private void invManagment_btn_MouseHover(object sender, EventArgs e)
        {
            invManagment_btn.ForeColor = Color.Yellow;
        }
        private void invManagment_btn_MouseLeave(object sender, EventArgs e)
        {
            invManagment_btn.ForeColor = Color.White;
        }
        private void cashBoxSetting_btn_MouseHover(object sender, EventArgs e)
        {
            cashBoxSetting_btn.ForeColor = Color.Yellow;
        }
        private void cashBoxSetting_btn_MouseLeave(object sender, EventArgs e)
        {
            cashBoxSetting_btn.ForeColor = Color.White;
        }
        private void cashBoxSet_btn_MouseHover(object sender, EventArgs e)
        {
            cashBoxSet_btn.ForeColor = Color.Yellow;
        }
        private void cashBoxSet_btn_MouseLeave(object sender, EventArgs e)
        {
            cashBoxSet_btn.ForeColor = Color.White;
        }
        private void cashBox_btn_MouseHover(object sender, EventArgs e)
        {
            cashBox_btn.ForeColor = Color.Yellow;
        }
        private void cashBox_btn_MouseLeave(object sender, EventArgs e)
        {
            cashBox_btn.ForeColor = Color.White;
        }
        private void exit_btn_MouseHover(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.IndianRed;
        }
        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Red;
        } 
        #endregion                                          
    }
}
